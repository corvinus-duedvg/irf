using Mikroszim.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mikroszim
{
    public partial class Form1 : Form
    {
        List<Person> Population = new List<Person>();
        List<BirthProbability> BirthProbabilities = new List<BirthProbability>();
        List<DeathProbability> DeathProbabilities = new List<DeathProbability>();

        List<int> NbrofFemales = new List<int>();
        List<int> NbrofMales = new List<int>();
        Random rng = new Random(1234);
        public Form1()
        {
            InitializeComponent();

            Population = GetPopulation(tbox_path.Text);
            BirthProbabilities = GetBP(@"C:\Temp\születés.csv");
            DeathProbabilities = GetDP(@"C:\Temp\halál.csv");
        }

        private void Simulation()
        {
            rtb_sim.Text = "";
            NbrofFemales.Clear();
            NbrofMales.Clear();
            for (int year = 2005; year <= nup_endyear.Value; year++)
            {
                for (int i = 0; i < Population.Count; i++)
                {
                    SimStep(year, Population[i]);
                }
                NbrofFemales.Clear();
                NbrofMales.Clear();
                NbrofMales.Add(
                    (from x in Population
                     where x.Gender == Gender.Male && x.IsAlive
                     select x).Count()
                                );
                NbrofFemales.Add(
                    (from x in Population
                     where x.Gender == Gender.Female && x.IsAlive
                     select x).Count()
                     );   
            }
            DisplayResults();
        }

        public List<Person> GetPopulation(string csvpath)
        {
            List<Person> population = new List<Person>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    population.Add(new Person()
                    {
                        BirthYear = int.Parse(line[0]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        NbrOfChildren = int.Parse(line[2])
                    });
                }
            }

            return population;
        }
        public List<BirthProbability> GetBP(string csvpath)
        {
            List<BirthProbability> bp = new List<BirthProbability>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    bp.Add(new BirthProbability()
                    {
                        Age = int.Parse(line[0]),
                        NbrOfChildren = int.Parse(line[1]),
                        P = double.Parse(line[2])
                    });
                }
            }

            return bp;
        }
        public List<DeathProbability> GetDP(string csvpath)
        {
            List<DeathProbability> dp = new List<DeathProbability>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    dp.Add(new DeathProbability()
                    {
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[0]),
                        Age = int.Parse(line[1]),
                        P = double.Parse(line[2])
                    });
                }
            }

            return dp;
        }
        private void SimStep(int year, Person person)
        {
            if (!person.IsAlive) return;
            byte age = (byte)(year - person.BirthYear);
            double pDeath = (from x in DeathProbabilities
                             where x.Gender == person.Gender && x.Age == age
                             select x.P).FirstOrDefault();
            if (rng.NextDouble() <= pDeath)
                person.IsAlive = false;
            if (person.IsAlive && person.Gender == Gender.Female)
            {
                double pBirth = (from x in BirthProbabilities
                                 where x.Age == age
                                 select x.P).FirstOrDefault();
                if (rng.NextDouble() <= pBirth)
                {
                    Person újszülött = new Person
                    {
                        BirthYear = year,
                        NbrOfChildren = 0,
                        Gender = (Gender)(rng.Next(1, 3))
                    };
                    Population.Add(újszülött);
                }
            }
        }

        private void but_path_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            tbox_path.Text = ofd.FileName;
            Population.Clear();
            Population = GetPopulation(tbox_path.Text);
        }

        private void but_sim_Click(object sender, EventArgs e)
        {
            Simulation();
        }

        private void DisplayResults()
        {
            string display="";
            if (NbrofFemales!=NbrofMales)
            {
                return;
            }
            for (int i = 0; i < NbrofFemales.Count; i++)
            {
                display = string.Concat(display, @"Szimulációs év: {i+2005} \n \t Lányok: {NbrofFemales[i]} \n \t Fiúk: {NbrofMales[i]} \n");
            }
            rtb_sim.Text = display;
        }
    }
}
