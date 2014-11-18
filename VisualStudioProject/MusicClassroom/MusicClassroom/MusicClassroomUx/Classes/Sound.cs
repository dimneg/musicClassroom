using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Papi.Negkas.MusicClassroom.Ux
{
  internal class Sound
  {
    public static bool Play(byte[] SoundBytes)
    {
      if (SoundBytes == null)
      {
        return false;
      }

      try
      {
        using (MemoryStream SoundStream = new MemoryStream(SoundBytes))
        {
          using (SoundPlayer player = new SoundPlayer(SoundStream))
          {
            player.Play();
          }
        }
        return true;
      }
      catch
      {
      }

      string Command = "close MIDIapp wait";
      MciSendString(Command, null, 0, IntPtr.Zero);

      // Try playing as midi
      string FileName = Application.StartupPath + "/midi.mid";
      File.WriteAllBytes(FileName, SoundBytes);

      Command = "open \"" + FileName + "\" alias MIDIapp wait";
      if (MciSendString(Command, null, 0, IntPtr.Zero) != 0)
      {
        return false;
      }

      Command = "Play MIDIapp";
      if (MciSendString(Command, null, 0, IntPtr.Zero) != 0)
      {
        return false;
      }

      return true;
    }

    [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
    private static extern int MciSendString(string Command, StringBuilder ReturnString, int cchReturn, IntPtr hwndCallback);
  }
}
