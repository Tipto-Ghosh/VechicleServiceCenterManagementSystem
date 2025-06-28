using VehicleServiceCenter.Repositories;

namespace VehicleServiceCenter
{
    internal static class Program
    {
        static void Main(string[] args)
        {

            //UserRepository userRepository = new UserRepository();



            AdminRepository adminRepository = new AdminRepository();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);



            //Application.Run(new LogIN());
            //Application.Run(new LoginForm());
            //Application.Run(new ShopForm());
            //Application.Run(new CarSelection());
            //Application.Run(new HondaForm());
            //AdminRepository adminRepository = new AdminRepository();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Admin());
            //Application.Run(new AdminCustomerForm());
            //Application.Run(new AdminForm());

            //Application.Run(new LoginForm());
            //Application.Run(new Customer_HomeForm());

            Application.Run(new LoginForm());
            //Application.Run(new Admin_ReceptionistForm(1000));

            //Application.Run(new Customer_HomeForm());

            //Application.Run(new AddReceptionistForm());

            // Tipto
            //arko

        }
    }
}
