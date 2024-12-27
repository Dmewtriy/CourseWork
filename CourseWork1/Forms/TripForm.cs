using CourseWork1.DTOs;
using CourseWork1.Interfaces;
using CourseWork1.Mappers;
using CourseWork1.Repositories;
using CourseWork1.Services;
using CourseWork1.Services.classes;
using CourseWork1.Services.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork1.Forms
{
    public partial class TripForm : Form
    {
        public event EventHandler<TripDTO> TripSubmitted;
        public TripForm(TripDTO Trip = null)
        {
            InitializeComponent();
            LoadData();
            Text = Trip == null ? "Добавить поездку" : "Редактировать поездку";
            if (Trip != null)
            {
                FillFormFields(Trip);
            }
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            int.TryParse(PriceTextBox.Text, out int price);
            int.TryParse(TouristNumberTextBox.Text, out int touristNumber);
            int.TryParse(PenaltyTextBox.Text, out int penalty);
            dynamic selectedRoute = RouteNameComboBox.SelectedItem;
            dynamic selectedRepresentative = RepresentativeComboBox.SelectedItem;
            if (selectedRoute != null && selectedRepresentative != null)
            {
                TripDTO Trip = new TripDTO()
                {
                    Id = id,
                    RouteName = (string)selectedRoute.Display,
                    Representative = (CompanyRepresentativeDTO)selectedRepresentative.Value,
                    Price = price,
                    TouristNumber = touristNumber,
                    Penalty = penalty,
                    StartDate = dateTimePicker1.Value,
                    EndDate = dateTimePicker2.Value,
                    Tourists = new List<ClientDTO>(),
                };
                foreach (DataGridViewRow row in ClientsDataGridView.Rows)
                {
                    Trip.Tourists.Add(row.Tag as ClientDTO);
                }
                TripSubmitted?.Invoke(sender, Trip);
            }
            else
            {
                MessageBox.Show("Необходимо заполнить все поля");
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        private void RemoveClientButtonClick(object sender, EventArgs e)
        {
            if(ClientsDataGridView.SelectedRows.Count > 0) 
            {
                DataGridViewRow row = ClientsDataGridView.SelectedRows[0];
                ClientsDataGridView.Rows.Remove(row);
            }
        }

        private bool IsClientAlreadyAdded(ClientDTO client)
        {
            foreach (DataGridViewRow row in ClientsDataGridView.Rows)
            {
                if ((row.Tag as ClientDTO)?.Id == client.Id)
                {
                    return true;
                }
            }
            return false;
        }

        private List<ClientDTO> LoadAvailableClients()
        {
            IRepository<IClient> repo = new ClientJsonRepository("..\\..\\..\\data\\clients");
            IClientService service = new ClientService(repo);
            var clients = service.GetAllClients();
            var clientsDTO = new List<ClientDTO>();
            foreach (var client in clients)
            {
                clientsDTO.Add(ClientMapper.ToDTO(client));
            }
            return clientsDTO;
        }

        private void LoadData()
        {
            IRepository<ICompanyRepresentative> repoCR = new CompanyRepresentativeJsonRepository("..\\..\\..\\data\\companyRepresentatives");
            IRepository<IRoute> repoR = new RouteJsonRepository("..\\..\\..\\data\\routes");

            var representatives = repoCR.GetAll();
            List<CompanyRepresentativeDTO> companyRepresentativeDTOs = new List<CompanyRepresentativeDTO>();
            foreach (var representative in representatives)
            {
                companyRepresentativeDTOs.Add(CompanyRepresentativeMapper.ToDTO(representative));
            }

            var routes = repoR.GetAll();
            List<RouteDTO> routeDTOs = new List<RouteDTO>();
            foreach (var route in routes)
            {
                routeDTOs.Add(RouteMapper.ToDTO(route));
            }

            foreach (var route in routeDTOs)
            {
                RouteNameComboBox.Items.Add(new
                {
                    Display = $"{route.Name}",
                    Value = route
                });
            }
            RouteNameComboBox.DisplayMember = "Display";
            RouteNameComboBox.ValueMember = "Value";

            foreach (var rep in companyRepresentativeDTOs)
            {
                RepresentativeComboBox.Items.Add(new
                {
                    Display = $"{rep.LastName} {rep.FirstName} {rep.Patronymic}",
                    Value = rep
                });
            }
            RepresentativeComboBox.DisplayMember = "Display";
            RepresentativeComboBox.ValueMember = "Value";
        }

        private void AddClientButtonClick(object sender, EventArgs e)
        {
            List<ClientDTO> availableClients = LoadAvailableClients();

            using (var selectionForm = new ClientsSelectionForm(availableClients))
            {
                if (selectionForm.ShowDialog() == DialogResult.OK)
                {
                    foreach (var client in selectionForm.SelectedClients)
                    {
                        if (!IsClientAlreadyAdded(client))
                        {
                            int index = ClientsDataGridView.Rows.Add();
                            ClientsDataGridView.Rows[index].Cells["ClientId"].Value = client.Id;
                            ClientsDataGridView.Rows[index].Cells["ClientLastName"].Value = client.LastName;
                            ClientsDataGridView.Rows[index].Cells["ClientFirstName"].Value = client.FirstName;
                            ClientsDataGridView.Rows[index].Cells["ClientPatronymic"].Value = client.Patronymic;
                            ClientsDataGridView.Rows[index].Cells["ClientBirthDate"].Value = client.DateOfBirth.ToShortDateString();
                            ClientsDataGridView.Rows[index].Cells["ClientPassport"].Value = client.PassportData.ToString();
                            ClientsDataGridView.Rows[index].Tag = client;
                        }
                    }
                }
            }
        }
    }
}
