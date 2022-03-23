using Microsoft.Win32;
using System;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace asciify3._0
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

        //file path string to be used anywhere
        public string selectedFilePath;
        public byte[] pixels;


        private void mitOpenFile_Click(object sender, RoutedEventArgs e)
        {
            //Create Instance of the OpenFileDialog Class
            OpenFileDialog openFile = new OpenFileDialog();

            //Set Filter so only files types we want are selectable
            openFile.Filter = "PNG Files | *.png; | JPEG Files | *jpg; jpeg;";

            //Show the dialog box and wait for the use to select an image
            bool fileSelected = openFile.ShowDialog() == true;

            //If user selected a file then open the image and send to imagebox
            if (fileSelected)
            {//Get the file the user selected
                selectedFilePath = openFile.FileName;
                //Create uri to hold the file path
                Uri uriTemp = new Uri(selectedFilePath);

                BitmapMaker bmpTemp = new BitmapMaker(selectedFilePath);

                //Send uri to bitmapimage class
                BitmapImage bmiTemp = new BitmapImage(uriTemp);
                //Set the source of the image box to the bitmapimage
                imgMain.Source = bmiTemp;

                BitmapMaker bmmTemp = new BitmapMaker(selectedFilePath);
                byte[] pixels = bmmTemp.GetPixelData();
                DisplayPixelData(pixels);
            }//end if
        }//end event

        public void DisplayPixelData(byte[] pixels)
        {
            for (int i = 0; i < pixels.Length; i += 4)
            {
                lstPixels.Items.Add($"pixel # {i / 4}");

                lstPixels.Items.Add($"blue =  {pixels[i + 0]}");    //add all items to listbox
                lstPixels.Items.Add($"grn  =  {pixels[i + 1]}");
                lstPixels.Items.Add($"red  =  {pixels[i + 2]}");
                lstPixels.Items.Add($"alp  =  {pixels[i + 3]}");
                lstPixels.Items.Add("-----------");

                double blue = pixels[i + 0];
                double grn = pixels[i + 1];
                double red = pixels[i + 2];
                double alphaColor = pixels[i + 3];
                double avgColor = ((blue + grn + red) / 3); //get average color
            }//end for
        }//end display pixel method

        public string Asciitize(BitmapMaker bmpTemp)
        {
            StringBuilder sb = new StringBuilder();     //sb to build ascii art
            int kernelW;
            int kernelH;
            bool kernelWPassed = int.TryParse(txtKernelWidth.Text, out kernelW);
            bool kernalHPassed = int.TryParse(txtKernelHeight.Text, out kernelH);

            int width = bmpTemp.Width;
            int height = bmpTemp.Height;

            if(kernelH > bmpTemp.Height || kernelH <= 0)
            {
                kernelH = 1;
                txtKernelHeight.Text = "1";
            }//end kernel height validation
            if(kernelW > bmpTemp.Width || kernelW <= 0)
            {
                kernelW = 1;
                txtKernelWidth.Text = "1";
            }//end kernel width valdation

            for (int h = 0; h < height; h+= kernelH) //loop through incremeting by height and width
            {
                for (int w = 0; w < width; w+= kernelW)
                {
                    Color pixelColor = bmpTemp.GetPixelColor(w, h);

                    double index = AverageColor(pixelColor);

                    sb.Append(GreyToString(index));
                }//end width for loop
                sb.Append("\n");
            }//end height for loop

            string ascii = ToString(sb);
            return ascii;
        }//end grey to string method

        string ToString(StringBuilder sb)
        {
            string asciiArt = sb.ToString();
            return asciiArt;
        }//end tostring override method

        double AveragePixel(Color color)
        {
            return (0.2126 * color.R) + (0.7152 * color.G) + (0.0722 * color.B);
        }//end average pixel method

        double AverageColor(Color pixelColors)
        {         
           double normalizedValue = AveragePixel(pixelColors) / 255;
           return normalizedValue;
        }//end average color method

        public string GreyToString(double normalizedColor)
        {
            StringBuilder greyToString = new StringBuilder();

            if (normalizedColor >= 0.0 && normalizedColor <= 0.25)
            {
                greyToString.Append("#");
            }
            else if (normalizedColor >= 0.25 && normalizedColor <= 0.45)
            {
                greyToString.Append("@");
            }
            else if (normalizedColor >= 0.45 && normalizedColor <= 0.55)
            {
                greyToString.Append("%");
            }
            else if (normalizedColor >= 0.55 && normalizedColor <= 0.65)
            {
                greyToString.Append("+");
            }
            else if (normalizedColor >= 0.65 && normalizedColor <= 0.75)
            {
                greyToString.Append(".");
            }
            else if (normalizedColor >= 0.75 && normalizedColor <= 1.00)
            {
                greyToString.Append(" ");
            }
            return greyToString.ToString();
        }//end grey to string method

        private void btnConvertToAscii_Click(object sender, RoutedEventArgs e)
        {
            BitmapMaker bmp = new BitmapMaker(selectedFilePath);
            string ascii = Asciitize(bmp);
            txtAscii1.Text = ascii;
        }//end asciitize event 

        
       
    }//end class
}//end namespace