using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123Examples;
namespace TestProject
{ 
        [TestClass]
        class PersonTest
        {
            [TestMethod]
            public void CreatePerson()
            {
                //given
                string firstName = "ddd";
                string lastName = "ccc";

                //when
                Person person = new Person(firstName, lastName);

                //then
                Assert.AreEqual(firstName, person.FirstName);
                Assert.AreEqual(lastName, person.LastName);
            }
        }
    }


