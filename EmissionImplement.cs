using System;

namespace EmissionImplement
{
	class EmissionImplement
	{
		double tramEmission; //Tonnes of C02 emission (will be small)
		double  trainEmission;
		double busEmission;
		double total;
		
		public string getTrainEmission(){
			return standardise(trainEmission);
		}
		public string getTramEmission(){
			return standardise (tramEmission);
		}
		public string getBusEmission(){
			return standardise (busEmission);
		}
		public string getTotalEmission(){
			return standardise (total);
		}
		
		public EmissionImplement(double tramdist = 0, double traindist = 0, double busdist = 0){ //input distances in km
			tramEmission = tramdist * 0.00007148;
			trainEmission = traindist * 0.00005649;
			busEmission = busdist * 0.00014877;
			total = tramEmission + trainEmission + busEmission;	
		}
		public void printEmissions(){//just for debugging
			Console.WriteLine ("Train Emissions {0} tonnes of C02", getTrainEmission());
			Console.WriteLine ("Tram Emissions {0} tonnes of C02", getTramEmission());
			Console.WriteLine ("Bus Emissions {0} tonnes of C02", getBusEmission());
			Console.WriteLine ("Total Emissions {0} tonnes of C02", getTotalEmission());
		}
		public string standardise(double input){ //returns decimal in scientific form (0.006 becomes 6.00e-3)
			double standard = input;
			int count = 0; //counting decminal places
			string standardReturn;
			
			if (input==0) return "0";
			
			do{
				standard*=10;
				count--;
			}while (standard < 1);
			standardReturn = String.Format("{0:0.000} e {1}", standard, count); 
			
			return standardReturn;
		}
	}
}
