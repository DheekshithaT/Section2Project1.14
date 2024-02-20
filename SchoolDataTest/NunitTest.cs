using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using Rainbowschool;
namespace SchoolDataTest
    {
        [TestFixture]
        public class Tests
        {

            [SetUp]
            public void Setup()
            {
            }

            [Test]
            public void TeacherNullTest()
            {
                foreach (var s in SchoolMng.allTeacher())
                {


                    Assert.IsNotNull(s.Tid);
                    Assert.IsNotNull(s.TeacherName);
                }
            }
            [Test]
            public void StudentNull()
            {
                int RollNumber = 1;
                Assert.IsNotNull(SchoolMng.EmpById(RollNumber));
            }
            [Test]
            public void MoqTeacherName()
            {
                var Tname = new Mock<Teachers>();
                var teacher = Tname.Object;
                Assert.IsNotNull(teacher);
            }
        }
    }