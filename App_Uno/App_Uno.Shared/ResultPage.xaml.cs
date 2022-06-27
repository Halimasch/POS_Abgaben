using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App_Uno
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ResultPage : Page
    {
        public ResultPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter is string[] values)
            {
                string ip = values[0];
                int mask = int.Parse(values[1]);
                string[] octets = ip.Split('.');
                string ipBit = "";
                foreach (string octet in octets)
                {
                    int octetInt = int.Parse(octet);
                    string octetString = "";
                    for (int i = 0; i < 8; i++)
                    {
                        if (octetInt % 2 == 0)
                            octetString += "0";
                        else
                        {
                            octetString += "1";
                        }
                        octetInt /= 2;
                    }
                    char[] charArray = octetString.ToCharArray();
                    Array.Reverse(charArray);
                    ipBit += new string(charArray);
                }
                netadd.Text = findNetAdd(ipBit, mask);
                minhost.Text = findFirstHost(ipBit, mask);
                maxhost.Text = findLastHost(ipBit, mask);
                broad.Text = findBroadCast(ipBit, mask);
                netaddbin.Text = findNetAddbin(ipBit, mask);
                minhostbin.Text = findFirstHostbin(ipBit, mask);
                maxhostbin.Text = findLastHostbin(ipBit, mask);
                broadbin.Text = findBroadCastbin(ipBit, mask);

            }
        }
        public void OnClick2(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
                Frame.GoBack();
        }


        public String findNetAddbin(string add, int mask)
        {
            char[] charArray = add.ToCharArray();
            for (int i = mask; i < 32; i++)
            {
                charArray[i] = '0';
            }
            add = new string(charArray);
            add = add.Substring(0, 8) + "." + add.Substring(8);
            return add;
        }

        public String findNetAdd(string add, int mask)
        {
            char[] charArray = add.ToCharArray();
            for (int i = mask; i < 32; i++)
            {
                charArray[i] = '0';
            }
            add = new string(charArray);
            return formatIP(add);
        }

        public String findFirstHostbin(string add, int mask)
        {
            char[] charArray = add.ToCharArray();
            for (int i = mask; i < 32; i++)
            {
                charArray[i] = '0';
            }
            charArray[31] = '1';
            add = new string(charArray);
            add = add.Substring(0, 8) + "." + add.Substring(8);
            return add;
        }

        public String findFirstHost(string add, int mask)
        {
            char[] charArray = add.ToCharArray();
            for (int i = mask; i < 32; i++)
            {
                charArray[i] = '0';
            }
            charArray[31] = '1';
            add = new string(charArray);
            return formatIP(add);
        }
        public String findLastHost(string add, int mask)
        {
            char[] charArray = add.ToCharArray();
            for (int i = mask; i < 32; i++)
            {
                charArray[i] = '1';
            }
            charArray[31] = '0';
            add = new string(charArray);
            return formatIP(add);
        }

        public String findLastHostbin(string add, int mask)
        {
            char[] charArray = add.ToCharArray();
            for (int i = mask; i < 32; i++)
            {
                charArray[i] = '1';
            }
            charArray[31] = '0';
            add = new string(charArray);
            add = add.Substring(0, 8) + "." + add.Substring(8);
            return add;
        }

        public String findBroadCastbin(string add, int mask)
        {
            char[] charArray = add.ToCharArray();
            for (int i = mask; i < 32; i++)
            {
                charArray[i] = '1';
            }
            add = new string(charArray);
            add = add.Substring(0, 8) + "." + add.Substring(8);
            return add;
        }


        public String findBroadCast(string add, int mask)
        {
            char[] charArray = add.ToCharArray();
            for (int i = mask; i < 32; i++)
            {
                charArray[i] = '1';
            }
            add = new string(charArray);
            return formatIP(add);
        }
        public String formatIP(String add)
        {
            string[] octets = new string[4];
            int[] octetsInt = new int[4];
            octets[3] = add.Substring(24);
            octets[2] = add.Substring(16, 8);
            octets[1] = add.Substring(8, 8);
            octets[0] = add.Substring(0, 8);
            int j = 0;
            foreach (string octet in octets)
            {
                char[] chars = octet.ToCharArray();
                Array.Reverse(chars);
                for (int i = 0; i < 8; i++)
                {
                    if (chars[i] == '1')
                        octetsInt[j] += (int)Math.Pow(2.0, i);
                }
                j++;
            }
            return "" + String.Format("{0,3:D3}", octetsInt[0]) + "." + String.Format("{0,3:D3}", octetsInt[1])
                      + "." + String.Format("{0,3:D3}", octetsInt[2]) + "." + String.Format("{0,3:D3}", octetsInt[3]);

        }

    }
}

