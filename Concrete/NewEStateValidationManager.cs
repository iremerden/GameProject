using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class NewEStateValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.GamerId == 01 && gamer.FirstName == "Axel" && gamer.LastName == "Lee"
                && gamer.DateOfBirth == 1997 && gamer.NationalIdentitiyNumber == 123456789)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
