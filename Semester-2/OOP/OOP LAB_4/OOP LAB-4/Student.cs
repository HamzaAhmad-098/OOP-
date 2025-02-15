using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_4
{
    internal class Student
    {
        public string name;
        public int rollNumber;
        public float cgpa;
        public int matricMarks;
        public int fscMarks;
        public int ecatMarks;
        public string homeTown;
        public bool isHostelite;
        public bool isTakingScholarship;
        public float claculateMerit()
        {
            return (60*fscMarks/1200)+(40*ecatMarks/400);
        }
        public bool isEligibleforScholarship(float meritPercentage)
        {
            return (meritPercentage>80 && isHostelite);
        } 
        public Student()
        {
            name = null;
            rollNumber = 0;
            cgpa = 0;
            matricMarks = 0;
            fscMarks = 0;
            ecatMarks = 0;
            homeTown = null;
            isHostelite = false;
            isTakingScholarship = false;
        }
    }
}
