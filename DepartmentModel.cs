using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCusingSQLviewAutoGen.Models
{
    public class DepartmentModel
    {

        [Required(AllowEmptyStrings = false, ErrorMessage = "Deptno can not be blank")]
        [RegularExpression("\\d{3}", ErrorMessage = "Department should be 3 digits")]
        public int depno { get; set; }

        [Required(ErrorMessage = "Dname can not be blank")]
        [StringLength(100, MinimumLength = 2)]
        public string dname { get; set; }

        [Required(ErrorMessage = "location can not be blank")]
        [StringLength(100, MinimumLength = 2)]
        public string location { get; set; }




    }
}