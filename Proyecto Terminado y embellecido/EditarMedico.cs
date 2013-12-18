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
    public partial class EditarMedico : Form
    {
        string id_medico;
        public EditarMedico(string identificacion)
        {
            InitializeComponent();
            cargarDatos(identificacion);
            id_medico = identificacion;
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditarMedico_Load(object sender, EventArgs e)
        {

        }

        private void txt_salario_TextChanged(object sender, EventArgs e)
        {

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
                    txt_codicoM.Text =(reader[3].ToString());
                    cmb_horario.Text = (reader[4].ToString());
                    txt_codsup.Text = (reader[5].ToString());
                    Bx_tipo_id_sup.Text = (reader[6].ToString());
                    txt_tipo.Text = (reader[7].ToString());
                    txt_salario.Text = (reader[8].ToString());
                    c.Close();
                }else{
                    MessageBox.Show("No hay consultas registradas");
                    c.Close();
                }

            }catch{
                MessageBox.Show("Error en la consulta, contacte al administrador del sistema");
                c.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();

            //hacemos la comexión 
            string update = "update scott.medico ";
            update += "set identificacion= :id, tipo_id= :tid, codigo_medico= :cod_med, nombre_medico= :nom,horario_medico= :hor ,id_medico_supervisor= :supervisor,tipo_id_supervisor= :tip_super,tipo_categoria= :tip_cat, salario= :sal ";
            update += "Where identificacion = :idp";
            //validamos que nos inyecten SQL                  
            c.get_cmd().CommandText = update;
            c.get_cmd().CommandType = CommandType.Text;
            c.get_cmd().Parameters.Add("id", txt_id.Text);
            c.get_cmd().Parameters.Add("tid", cboTipo.SelectedItem);
            c.get_cmd().Parameters.Add("cod_med", txt_codicoM.Text);
            c.get_cmd().Parameters.Add("nom", txt_nombre.Text);
            c.get_cmd().Parameters.Add("hor", cmb_horario.SelectedItem);
            c.get_cmd().Parameters.Add("supervisor", txt_codsup.Text);
            c.get_cmd().Parameters.Add("tip_super", Bx_tipo_id_sup.SelectedItem);
            c.get_cmd().Parameters.Add("tip_cat", txt_tipo.Text);
            c.get_cmd().Parameters.Add("sal", txt_salario.Text);
            c.get_cmd().Parameters.Add("idp", id_medico);


            try //hacemos la inserción de la sentencia
            {
                c.get_cmd().ExecuteNonQuery();
                MessageBox.Show("Médico actualizado correctamente");
                c.Close();
            }
            catch { MessageBox.Show("No fue posible modificar el registro, consulte al administrador del sistema"); }

            this.Close();
        }
    }
}
