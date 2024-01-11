using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models;

    public class pageResponse
    {

        public List<passwords> userPasswords {  get; set; }

        public  int currentPage { get; set; }

        public double pages { get; set; }
    }
