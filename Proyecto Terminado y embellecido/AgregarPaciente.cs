using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AgregarPaciente : Form
    {
        public AgregarPaciente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();

            //hacemos la comexión 
            string insertar = "insert into  scott.paciente (num_identificacion_paciente, tipo_identificacion,nombre_paciente,fdenac_paciente,direccion_paciente)";
            insertar += ":id,:tid,:npaciente,:fnacimiento,:dpaciente";
            
            //validamos que nos inyecten SQL                  
            c.get_cmd().CommandText = insertar;
            c.get_cmd().CommandType = CommandType.Text;
            c.get_cmd().Parameters.Add("id", txt_identificacion.Text);
            c.get_cmd().Parameters.Add("tid", cmb_tipo.SelectedItem);
            c.get_cmd().Parameters.Add("npaciente", txt_nombre.Text);
            c.get_cmd().Parameters.Add("fnacimiento", txt_fecha.Text);
            c.get_cmd().Parameters.Add("dpaciente", txt_dir.Text);            


            try //hacemos la inserción de la sentencia
            {
                c.get_cmd().ExecuteNonQuery();
                MessageBox.Show("Paciente registrado correctamente");
                c.Close();               
            }
            catch { MessageBox.Show("No fue posible hacer el registro, consulte al administrador del sistema"); }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
