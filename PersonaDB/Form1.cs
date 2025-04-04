using PersonaDB.Controller;
using PersonaDB.Model;

namespace PersonaDB
{
    public partial class Form1 : Form
    {
        private PersonaController acciones = new PersonaController();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            gdPersona.DataSource = acciones.Leer();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Social ni = new Social(
                    Convert.ToInt32(tbId.Text),
                    tbName.Text,
                    tbLName.Text,
                    tbArcana.Text,
                    tbPersona.Text,
                    tbGrupo.Text
                );
                if (acciones.Insertar(ni))
                {
                    gdPersona.DataSource = null;
                    gdPersona.DataSource = acciones.Leer();
                    tbId.Text = "";
                    tbName.Text = "";
                    tbLName.Text = "";
                    tbArcana.Text = "";
                    tbPersona.Text = "";
                    tbGrupo.Text = "";
                    
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el elemento");
                }
            }
            catch (FormatException) // Específicamente capturamos el error de formato al intentar convertir el ID
            {
                MessageBox.Show("El ID debe ser un número válido.");
            }
            catch (Exception ex) // Para cualquier otro tipo de excepción
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}
