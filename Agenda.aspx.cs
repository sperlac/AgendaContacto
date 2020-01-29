using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgendaContactos
{
    public partial class Agenda2 : System.Web.UI.Page
    {
        public string current_path = string.Empty;
        public ListItem selectedItem = null;
        public IEnumerable<ListItem> textoLista = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            //Leer archivo y añadir información al combo
            current_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"agenda.txt");
            string[] lineOfContents = File.ReadAllLines(current_path);
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split('\n');
                this.contactos.Items.Add(tokens[0].Replace('|',','));
            }

            textoLista= this.contactos.Items.Cast<ListItem>();
        }

        protected void buscar_Click(object sender, EventArgs e)
        {
            //Busca en la lista de contactos cargada con la primera lectura del fichero y el resultado sale en el desplegable
            IEnumerable<ListItem> encontrados=null;
                
            encontrados= textoLista.Where(x => x.Value.Contains(this.info.Value));
            if (encontrados.ToList().Count()==0 || this.info.Value.Equals(""))
            {
                this.contactos.Items.Clear();
            }
            else
            {
                this.contactos.DataSource = encontrados.ToList();
                this.contactos.DataBind();
            }

        }
    }
}