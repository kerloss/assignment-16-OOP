using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_16
{
    internal class Car
    {
		#region Attributes
		private int id;
		private string model;
		private double speed;
		#endregion

		#region Properties
		public double Speed
		{
			get { return speed; }
			set { this.speed = value; }
		}

		public string Model
		{
			get { return model; }
			set { this.model = value; }
		}

		public int Id
		{
			get { return id; }
			set { this.id = value; }
		}
		#endregion

		#region Method
		public override string ToString()
		{
			return $"Id: {id} \nModel: {model} \nSpeed: {speed}";
		}
		#endregion

		#region Constructor chaining
		public Car(int _id, string _model, long _speed)
		{
			this.id = _id;
			this.model = _model;
			this.speed = _speed;
            Console.WriteLine("ctor1");
        }
        public Car(int _id , string _model) : this(_id, _model, 180)
        {
            //this.id = _id;
            //this.model= _model;
            //this.speed = 180;
            Console.WriteLine("ctor2");
        }
        public Car(int _id) : this(_id, "hundai")
        {
            //this.id = _id;
			//this.Model = "Hundai";
			this.speed = 320;
            Console.WriteLine("Ctor3");
        }
        #endregion
    }
}
