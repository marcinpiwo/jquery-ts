using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class FooViewModel
    {
        public FooViewModel()
        {
            SubModel = new SubModel();
            Sub2Model = new Sub2Model();
        }

        public FooViewModel(Sub2Model sub2Model)
        {
            SubModel = new SubModel();
            Sub2Model = sub2Model;
        }

        [Required]
        public string Waldo { get; set; }

        public SubModel SubModel { get; set; }

        public Sub2Model Sub2Model { get; set; }
    }

    public class SubModel
    {
        [Required]
        public string Blah { get; set; }
    }

    public class Sub2Model
    {
        [Required]
        public string Blah2 { get; set; }
    }
}
