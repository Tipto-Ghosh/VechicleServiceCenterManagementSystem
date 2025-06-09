using System;
using System.Collections.Generic;
using System.Linq;
using VehicleServiceCenter.Models;
using VehicleServiceCenter.Repositories;


namespace VehicleServiceCenter.Services {
   public class UserService {
        private UserRepository userRepository;
        private User loggedInUser;
        public UserService() {
            userRepository = new UserRepository();
        }

        // This is method that will take the UserID and Password for login
        public User Login(int UserID , string Password) {
            try {
                User user = userRepository.GetUserById(UserID);

                if(user == null) {
                    return null; // User not found
                }

                if(user.Password != Password) {
                    return null; // wrong pass
                }

                this.loggedInUser = user;
                return user;

            }catch(Exception ex) {
                Console.WriteLine("Login Failed" + ex.Message);
                return null;
            }
        }

        public void Logout() {
            this.loggedInUser = null;
        }

        public User GetUserById(int userId) {
            try {
               User user =  userRepository.GetUserById(userId);
                return user;

            } catch (Exception ex) {
                Console.WriteLine("Error fetching user: " + ex.Message);
                return null;
            }
        }

        
        public int ChangePassword(int userId, string oldPassword, string newPassword) {
            try {
                User user = userRepository.GetUserById(userId);

                if (user == null || user.Password != oldPassword) {
                    return 0; 
                }

                user.Password = newPassword;
                int updateStatus = userRepository.UpdateUser(user);
                return updateStatus;
            } catch (Exception ex) {
                return 0;
            }
        }

        public int UpdateProfile(User updatedUser) {
            try {
                int updateStatus = userRepository.UpdateUser(updatedUser);
                return updateStatus;
            } catch (Exception ex) {
                Console.WriteLine("Profile update failed: " + ex.Message);
                return 0;
            }
        }
    }
}