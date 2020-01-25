using Registro.BLL;
using Registro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Registro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdTextBox.Text = string.Empty;
            NombreTextBox.Text = string.Empty;
            TelefonoTextBox.Text = string.Empty;
            CedulaTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            FechaNacimientoDateTimePicker.Text = string.Empty;
            
        }

        private void BtnNuevo_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private Persona LlenaClase()
        {
            Persona persona = new Persona();
            persona.PersonaID = Convert.ToInt32(IdTextBox.Text);
            persona.Nombre = NombreTextBox.Text;
            persona.Telefono = TelefonoTextBox.Text;
            persona.Direccion = DireccionTextBox.Text;
            persona.FechaNacimiento = Convert.ToDateTime(FechaNacimientoDateTimePicker);

            return persona;
        }

        private void LlenaCampo(Persona persona)
        {
            int id = Convert.ToInt32(IdTextBox.Text);
             _ = Convert.ToDateTime(value: FechaNacimientoDateTimePicker);

            id = persona.PersonaID;
            NombreTextBox.Text = persona.Nombre;
            TelefonoTextBox.Text = persona.Telefono;
            CedulaTextBox.Text = persona.Cedula;
            DireccionTextBox.Text = persona.Direccion;
            _ = persona.FechaNacimiento;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Persona persona = PersonasBLL.Buscar((int)Convert.ToInt32(IdTextBox.Text));
            return (persona != null);
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Persona persona;
            bool paso = false;

            if (!Validar())
               return;

            persona = LlenaClase();

            if ((Convert.ToInt32(IdTextBox.Text)) == 0){
                paso = PersonasBLL.Guardar(persona);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Modificar la persona que no existe", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                paso = PersonasBLL.Modificar(persona);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
        
        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (NombreTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DireccionTextBox.Text))
            {
                MyErrorProvider.SetError(DireccionTextBox, "El campo Direccion no puede estar vacio");
                DireccionTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CedulaTextBox.Text.Replace("-", "")))
            {
                MyErrorProvider.SetError(CedulaTextBox, "El campo Cedula no puede estar vacio");
                CedulaTextBox.Focus();
                paso = false;

            }
            return paso;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int id;
            Persona persona = new Persona();
            int.TryParse(IdTextBox.Text, out id);

            Limpiar();

            persona = PersonasBLL.Buscar(id);

            if(persona!= null)
            {
                MessageBox.Show("Persona Encontrada");
            }
            else
            {
                MessageBox.Show("Persona no Encontrada");
            }
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(IdTextBox.Text, out id);

            Limpiar();

            if (PersonasBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MyErrorProvider.SetError(IdTextBox, "No se puede eliminar una persona que no existe");
        }
    }
}
