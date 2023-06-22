using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Runtime;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ScriptEngine engine;
        private ScriptScope scope;
        public Form1()
        {
            InitializeComponent();

            engine = Python.CreateEngine();
            scope = engine.CreateScope();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                // Get the values from the textboxes
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                // Execute the IronPython script
                string scriptPath = @"C:\Users\ntpdtrainee6\source\repos\WindowsFormsApp1-master\WindowsFormsApp1\PythonApplication1.py"; // Replace with the actual path to your Python script
                engine.ExecuteFile(scriptPath, scope);

                // Get the addition function from the IronPython script
                dynamic add = scope.GetVariable("addition");

                // Call the addition function with textbox values as arguments
                dynamic sum = add(num1, num2);

                // Update the third textbox with the result
                textBox3.Text = sum.ToString();
           
        }
    }
    }

