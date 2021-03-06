// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   DataSource.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Entities=WPAppStudio.Entities;
using RepositoriesBase=WPAppStudio.Repositories.Base;
using WPAppStudio.Shared;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// FreshCoffee_FreshCoffee data source.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public class FreshCoffee_FreshCoffee : IFreshCoffee_FreshCoffee 
    {
		private const int MaxResults = 10;
        private readonly ObservableCollection<Entities.FreshCoffeeSchema> _data = new ObservableCollection<Entities.FreshCoffeeSchema>
		{
          new Entities.FreshCoffeeSchema
            {
                Id= new Guid("12f8a8b0-57f7-49a1-a86b-d49c3f66da09"),
                Title=@"Chocolate",
                Subtitle=@"Chocolate",
                Image=@"\Images\Item-c8c8c7d1-6dd2-4ff3-9977-c5eec55aac1c.jpg",
                Description=@"hot  35 ฿
cool 40 ฿
spin 45 ฿",
			},
          new Entities.FreshCoffeeSchema
            {
                Id= new Guid("ad180918-f050-4b58-8e5a-6c5d7ecbd7fa"),
                Title=@"Fresh Coffee",
                Subtitle=@"Fresh Coffee",
                Image=@"\Images\Item-e9caddd1-44fd-4e7a-878f-e51a47b6932d.jpg",
                Description=@"hot  40 ฿
cool 45 ฿
spin 50 ฿",
			},
          new Entities.FreshCoffeeSchema
            {
                Id= new Guid("5d392359-a94e-4729-8911-71a994354bb3"),
                Title=@"Fresh Milk",
                Subtitle=@"Fresh Milk",
                Image=@"\Images\Item-ef59a4f8-643d-4592-ba61-8d200c6b5eb1.jpg",
                Description=@"hot   35 ฿
cool  40 ฿
spin  45 ฿",
			},
          new Entities.FreshCoffeeSchema
            {
                Id= new Guid("609c431f-1f7d-4d15-a4ac-fe2ed8c4186f"),
                Title=@"Green Tea",
                Subtitle=@"Green Tea",
                Image=@"\Images\Item-3288772d-bc2a-4d25-9608-2d0bc7e2bdd9.jpg",
                Description=@"hot  35 ฿
cool 40 ฿
spin 45 ฿",
			},
          new Entities.FreshCoffeeSchema
            {
                Id= new Guid("8b7c1ebb-b207-42dc-9919-49ff2c02c16a"),
                Title=@"Red Tea",
                Subtitle=@"Red Tea",
                Image=@"\Images\Item-81ac61ea-b2c8-4707-9612-7a90af6a09a2.jpg",
                Description=@"hot  35 ฿
cool 40 ฿
spin 45 ฿",
			},
		};
	
		
        /// <summary>
        /// Retrieves the data from a static data source, in an observable collection of FreshCoffeeSchema items.
        /// </summary>
        /// <returns>An observable collection of FreshCoffeeSchema items.</returns>
        public ObservableCollection<Entities.FreshCoffeeSchema> GetData(int numPage)
        {								
			return new ObservableCollection<Entities.FreshCoffeeSchema>(_data.Skip(MaxResults * numPage).Take(MaxResults));
        }
		
		/// <summary>
        /// Retrieves the data from a static data source, filtered by a filter specification, in an observable collection of FreshCoffeeSchema items.
        /// </summary>
		/// <param name="filter">Filter operation specification</param>
        /// <returns>An observable collection of FreshCoffeeSchema items.</returns>
        public ObservableCollection<Entities.FreshCoffeeSchema> Search(FilterSpecification filter)
        {
            return RepositoriesBase.Filter<Entities.FreshCoffeeSchema>.FilterCollection(filter, _data);
        }
		
		/// <summary>
        /// Checks if data source has a element before the passed as parameter
        /// </summary>
		/// <param name="current">Current element</param>
        /// <returns>True, if there is a previous element, false if there is not</returns>
		public bool HasPrevious(Entities.FreshCoffeeSchema current)
        {
            if (current == null || !_data.Any()) return false;

            return _data.IndexOf(current) > 0;
        }
		
		/// <summary>
        /// Checks if data source has a element after the passed as parameter
        /// </summary>
		/// <param name="current">Current element</param>
        /// <returns>True, if there is a next element, false if there is not</returns>
		public bool HasNext(Entities.FreshCoffeeSchema current)
        {
            if (current == null || !_data.Any()) return false;

            return _data.IndexOf(current) < _data.Count - 1;
        }
		
		/// <summary>
        /// Retrieves the previous element from source.
        /// </summary>
		/// <param name="current">Current element</param>
        /// <returns>The previous element from items, if it exists. Otherwise, returns null</returns>
        public Entities.FreshCoffeeSchema Previous(Entities.FreshCoffeeSchema current)
        {
            if (current == null || !_data.Any()) return null;

            if (_data.First().Equals(current)) return null;

            return _data[_data.IndexOf(current) - 1];
        }
		
		/// <summary>
        /// Retrieves the next element from source.
        /// </summary>
		/// <param name="current">Current element</param>
        /// <returns>The next element from items, if it exists. Otherwise, returns null</returns>
        public Entities.FreshCoffeeSchema Next(Entities.FreshCoffeeSchema current)
        {
            if (current == null || !_data.Any()) return null;

            if (_data.Last().Equals(current)) return null;

            return _data[_data.IndexOf(current) + 1];
        }
	}
}

