﻿namespace Contracts.CategoryContracts.Request
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UpdateCategoryRequest
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Summary { get; set; }

        public int? IdUpperCategory { get; set; }
    }
}
