using System;

using System.Collections.Generic;

namespace CSharp.Biz
{
    public class Collections
    {
        public Collections()
        {
            //var colorOptions = new List<string>();
            //colorOptions.Add("Red");
            //colorOptions.Add("Espresso");
            //colorOptions.Add("White");
            //colorOptions.Add("Navy");
            //colorOptions.Insert(2, "Purple");
            //colorOptions.Remove("White");
            var colorOptions = new List<string>() { "Red", "Espresso", "White", "Navy" };
            Console.WriteLine(colorOptions);
        }
        public Collections(int collectionsId,
                        string collectionsName,
                        string description) : this()
        {
            this.CollectionsId = collectionsId;
            this.CollectionsName = collectionsName;
            this.Description = description;
        }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public int CollectionsId { get; set; }

        private string collectionsName;
        public string CollectionsName
        {
            get
            {
                var formattedValue = collectionsName?.Trim();
                return formattedValue;
            }
            set
            {
                if (value.Length < 3)
                {
                    ValidationMessage = "Product Name must be at least 3 characters";
                }
                else if (value.Length > 20)
                {
                    ValidationMessage = "Product Name cannot be more than 20 characters";

                }
                else
                {
                    collectionsName = value;

                }
            }
        }
        public string ValidationMessage { get; private set; }
        public override string ToString()
        {
            return this.CollectionsName + " (" + this.CollectionsId + ")";
        }

    }
}
