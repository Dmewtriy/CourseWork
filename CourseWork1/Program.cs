using CourseWork1.Forms;
using CourseWork1.Interfaces;
using CourseWork1.Presenters.classes;
using CourseWork1.Repositories;
using CourseWork1.Services;
using CourseWork1.Services.classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseWork1
{
    internal class Program
    {
        [STAThreadAttribute]
        static void Main()
        {
            IRepository<IClient> repo = new ClientJsonRepository("..\\..\\..\\data\\clients");
            IClientService service = new ClientService(repo);
            ClientsForm clients = new ClientsForm();
            ClientPresenter presenter = new ClientPresenter(service, clients);
            Application.Run(clients);
        }
    }
}
