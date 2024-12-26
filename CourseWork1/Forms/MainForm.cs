using CourseWork1.Interfaces;
using CourseWork1.Presenters.classes;
using CourseWork1.Repositories;
using CourseWork1.Services.classes;
using CourseWork1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork1.Presenters.interfaces;
using CourseWork1.Services.interfaces;

namespace CourseWork1.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ClientsButtonClick(object sender, EventArgs e)
        {
            IRepository<IClient> repo = new ClientJsonRepository("..\\..\\..\\data\\clients");
            IClientService service = new ClientService(repo);
            ClientsForm clients = new ClientsForm();
            IClientPresenter presenter = new ClientPresenter(service, clients);
            clients.ShowDialog();
        }

        private void CompanyRepresentativesButtonClick(object sender, EventArgs e)
        {
            IRepository<ICompanyRepresentative> repo = new CompanyRepresentativeJsonRepository("..\\..\\..\\data\\companyRepresentatives");
            ICompanyRepresentativeService service = new CompanyRepresentativeService(repo);
            CompanyRepresentativesForm compReps = new CompanyRepresentativesForm();
            ICompanyRepresentativePresenter presenter = new CompanyRepresentativePresenter(service, compReps);
            compReps.ShowDialog();
        }

        private void ExcursionsButtonClick(object sender, EventArgs e)
        {
            IRepository<IExcursion> repo = new ExcursionJsonRepository("..\\..\\..\\data\\excursions");
            IExcursionService service = new ExcursionService(repo);
            ExcursionsForm form = new ExcursionsForm();
            IExcursionPresenter presenter = new ExcursionPresenter(service, form);
            form.ShowDialog();
        }

        private void PointsButtonClick(object sender, EventArgs e)
        {

        }

        private void RoutesButtonClick(object sender, EventArgs e)
        {

        }

        private void TripsButtonClick(object sender, EventArgs e)
        {

        }
    }
}
