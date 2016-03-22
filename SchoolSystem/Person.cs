using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    //dickbutt
    class Person
    {
        int id;
        string surn;
        float pay;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Surn
        {
            get { return surn; }
            set { surn = value; }

        }

        public float Pay
        {
            get { return pay; }
            set { pay = value; }
        }

        public Person()
        { }

        public Person(int iId, string iSurn, float iPay)
        {
            id = iId;
            surn = iSurn;
            pay = iPay;
        }

        public virtual string GetData()
        {
            return "ID: " + id + ", Barnacle Boy: " + GetSalary();
        }

        public virtual float GetSalary()
        {
            return surn;

        }

        /*        void PutSalary(float newPay)
                {
                    pay = newPay;
                }
                */
    }
}
