using System;
using VehicleServiceCenter.Models;

namespace VehicleServiceCenter.Repositories
{
    internal class InventoryManagerRepository
    {

        // Insert a new Inventory manager.
        public int InsertInventoryManager(InventoryManager inv)
        {
            try
            {
                UserRepository userRepo = new UserRepository();
                int newId = userRepo.InsertUser(inv);
                // If failed id will be 0 , if already existis then id = -1 else new id
                return newId;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int DeleteInventoryManager(int id)
        {
            try
            {
                UserRepository userRepo = new UserRepository();
                return userRepo.DeleteUser(id); // return the id if success otherwise
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int UpdateInventoryManager(InventoryManager inv)
        {
            try
            {
                UserRepository userRepo = new UserRepository();
                return userRepo.UpdateUser(inv);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public bool ChangePassword(int invManId, string newPass)
        {
            UserRepository userRepo = new UserRepository();

            bool isChanged = userRepo.ChangePassword(invManId, newPass);
            return isChanged;
        }
    }

}