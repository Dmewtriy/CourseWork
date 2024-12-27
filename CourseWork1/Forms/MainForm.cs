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
            IRepository<IRoutePoint> repo = new RoutePointJsonRepository("..\\..\\..\\data\\routePoints");
            IRoutePointService service = new RoutePointService(repo);
            RoutePointsForm form = new RoutePointsForm();
            IRoutePointPresenter presenter = new RoutePointPresenter(service, form);
            form.ShowDialog();
        }

        private void RoutesButtonClick(object sender, EventArgs e)
        {
            IRepository<IRoute> repo = new RouteJsonRepository("..\\..\\..\\data\\routes");
            IRouteService service = new RouteService(repo);
            RoutesForm form = new RoutesForm();
            IRoutePresenter presenter = new RoutePresenter(service, form);
            form.ShowDialog();
        }

        private void TripsButtonClick(object sender, EventArgs e)
        {
            IRepository<ITrip> repo = new TripJsonRepository("..\\..\\..\\data\\trips");
            ITripService service = new TripService(repo);
            TripsForm form = new TripsForm();
            ITripPresenter presenter = new TripPresenter(service, form);
            form.ShowDialog();
        }
    }
}
