using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService) 
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("SignUp is Succesful.");
            }
            else
            {
                Console.WriteLine("Validation Failure, Try Again.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Registry is Deleted.");
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Update Informations are Verified. Update is Succesful.");
            }
            else
            {
                Console.WriteLine("Update is Failed.");
            }
        }
    }
}
