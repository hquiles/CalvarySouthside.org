using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalvarySouthside
{
    public class Person
    {
        #region Properties

        public int Id { get; set; }
        public DateTime DateRegistered { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public bool ConfirmedEmail { get; set; }
        public bool EmailList { get; set; }
        public string PhoneNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public DateTime Birthday { get; set; }

        #endregion

        #region Constructors

        public Person()
        {
        
        }

        /// <summary>
        /// Automatically loads the person
        /// </summary>
        /// <param name="personId"></param>
        public Person(int personId)
        {
            // load the person
        }

        #endregion

        #region Methods

        /// <summary>
        /// Upserts the current user to the People table
        /// </summary>
        public void Save()
        {
            // upsert
        }

        #endregion


    }
}
