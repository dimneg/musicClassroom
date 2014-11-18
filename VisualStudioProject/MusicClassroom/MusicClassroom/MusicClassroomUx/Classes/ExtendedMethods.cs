using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace Papi.Negkas.MusicClassroom.Ux
{
    internal static class ExtendedMethods
    {
        public static void LoadFromResource(this RichTextBox TextBox, string Resource)
        {
            using (MemoryStream ByteStream = new MemoryStream(Encoding.ASCII.GetBytes(Resource)))
            {
                TextBox.LoadFile(ByteStream, RichTextBoxStreamType.RichText);
            }
        }

        public static T GetBoundItem<T>(this DataGridViewRow Row)
            where T : class 
        {
            DataRowView view = Row.DataBoundItem as DataRowView;
            if (view != null)
            {
                T item = view.Row as T;
                return item;
            }
            return null;
        }

        public static T GetSelectedItem<T>(this DataGridView List)
            where T : class
        {
          if (List.SelectedRows.Count > 0)
          {
            DataRowView view = List.SelectedRows[0].DataBoundItem as DataRowView;
            if (view != null)
            {
              T item = view.Row as T;
              return item;
            }
          }
          return null;
        }
    }
}
