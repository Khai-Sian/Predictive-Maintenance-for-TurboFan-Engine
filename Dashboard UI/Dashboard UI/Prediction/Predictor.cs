using System;
using System.Diagnostics;

namespace Dashboard_UI
{
    class Predictor
    {
        /// <summary>
        /// Python used to run the script
        /// </summary>
        public string pythonfile { get; set; }

        /// <summary>
        /// Python Script to run
        /// </summary>
        public string pythonScript { get; set; }

        //Constructor
        public Predictor(string filename, string script)
        {
            pythonfile = filename;
            pythonScript = script;
        }

        /// <summary>
        /// predict RUL of engine
        /// </summary>
        /// <param name="machineID"></param>
        /// <param name="modelFile"></param>
        /// <param name="lastCycle"></param>
        /// <returns></returns>
        public double prediction(string modelFile, Cycle lastCycle)
        {
            var psi = new ProcessStartInfo();
            psi.FileName = pythonfile;

            var script = pythonScript;

            double[] sensorsArray = new double[21];

            //loop object variables to add to array 
            for (int i = 1; i <= 21; i++)
            {
                double value = (double)lastCycle.GetType().GetProperty("s_" + i).GetValue(lastCycle, null);
                sensorsArray[i - 1] = value;
            }

            string sensors = string.Join(", ", sensorsArray);

            psi.Arguments = $"\"{script}\" \"{modelFile}\" \"{sensors}\""; //arguments to python script

            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            var error = "";
            var output = "";

            using (var process = Process.Start(psi))
            {
                error = process.StandardError.ReadToEnd();
                output = process.StandardOutput.ReadToEnd();
            }

            Console.WriteLine("Error: " + error);

            //return RUL;
            Debug.WriteLine($"Output: {output}");
            return double.Parse(output);
        }
    }
}
