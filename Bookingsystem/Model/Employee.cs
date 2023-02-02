using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookingsystem.Model
{
    public class Employee
    {
		private string _phone;
        private string _name;
        private string _frisør;

        public string Phone
		{
			get { return _phone; }
			set { _phone = value; }
		}

		
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		

		public string Frisør
		{
			get { return _frisør; }
			set { _frisør = value; }
		}

		public Employee()
		{

		}

		public Employee(string Phone,string Name, string Frisør)
		{
			_phone= Phone;
			_name= Name;
			_frisør = Frisør;

		}

        public override string ToString()
        {
            return $" Phone number: {_phone}  Name: {_name}  Frisør: {_frisør}";   
        }

    }
}
