using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaConsoleMVC_Task
{
    public class Services
    {

        public void Add()
        {

        }
        public void Operations()
        {
            Console.WriteLine("1_ Add users:\n2_Get User:\n3_Update user:\n4_Delete user:");
            byte choose=byte.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        Add();break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break ;
                    }
                case 4:
                    {
                        break;
                    }
                default:
                    { Console.WriteLine("ther is no operations in :"+choose);break; }

                
            }
        }
    }
}
