using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormAcercaDe : Form
    {
        public FormAcercaDe()
        {
            InitializeComponent();
            CargarTextoRichTextBox();
        }

        private void CargarTextoRichTextBox()
        {
            string texto = "So Abram went, as the Lord had told him; and Lot went with him. " +
                "Abram was seventy-five years old when he set out from Harran. He took his " +
                "wife Sarai, his nephew Lot, all the possessions they had accumulated and the " +
                "people they had acquired in Harran, and they set out for the land of Canaan, " +
                "and they arrived there Abram traveled through the land as far as the site " +
                "of the great tree of Moreh at Shechem. At that time the Canaanites were in the land." +
                "The Lord appeared to Abram and said, “To your offspring[c] I will give this land.” " +
                "So he built an altar there to the Lord, who had appeared to him";

            richTextBoxAppInfo.Text = texto;
        }
    }
}
