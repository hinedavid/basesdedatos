using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApplication1
{
    public partial class EliminarMedico : Form
    {
        string id_med;
        public EliminarMedico(string identificacion)
        {
            InitializeComponent();
            id_med = identificacion;
            cargarDatos(id_med);
        }


        private void cargarDatos(string cedula)
        {
            Conexion c = new Conexion();
            try
            {
                String query = "select * from scott.medico where identificacion= :id";
                c.get_cmd().CommandText = query;
                c.get_cmd().CommandType = CommandType.Text;
                //evitamos inyección SQL
                c.get_cmd().Parameters.Add("id", cedula);

                //****Ejecutamos la consulta mediante un DataReader de Oracle
                OracleDataReader reader = c.get_cmd().ExecuteReader();
                //***si se quiere en un dataset
                //Al adaptador hay que pasarle el string SQL y la Conexión
                OracleDataAdapter adapter = new OracleDataAdapter(c.get_cmd());


                if (reader.Read())
                {
                    txt_id.Text = reader[0].ToString();
                    cboTipo.Text = (reader[1].ToString());
                    txt_nombre.Text = (reader[2].ToString());
                    txt_codicoM.Text = (reader[3].ToString());
                    cmb_horario.Text = (reader[4].ToString());
                    txt_codsup.Text = (reader[5].ToString());
                    Bx_tipo_id_sup.Text = (reader[6].ToString());
                    txt_tipo.Text = (reader[7].ToString());
                    txt_salario.Text = (reader[8].ToString());
                    c.Close();
                }
                else
                {
                    MessageBox.Show("No hay consultas registradas");
                    c.Close();
                    
                }

            }
            catch
            {
                MessageBox.Show("Error en la consulta, contacte al administrador del sistema");
                c.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //establece la conexión
            Conexion c = new Conexion();

            //hacemos la comexión 
            String eliminar = "delete from scott.medico where  identificacion= :id ";
            //validamos que nos inyecten SQL                  
            c.get_cmd().CommandText = eliminar;
            c.get_cmd().CommandType = CommandType.Text;
            c.get_cmd().Parameters.Add("id", id_med);
            


            try //hacemos la inserción de la sentencia
            {
                c.get_cmd().ExecuteNonQuery();
                MessageBox.Show("Médico eliminado correctamente");
                c.Close();
                this.Close();
            }
            catch { MessageBox.Show("No fue eliminar el registro, consulte al administrador del sistema"); }
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
