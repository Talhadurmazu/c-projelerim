 var writer = new BarcodeWriter
 {
     Format = BarcodeFormat.QR_CODE,
     Options = new ZXing.Common.EncodingOptions
     {
         Width = 250,
         Height = 250
     }
 };
 var result = writer.Write(textBox1.Text);
 pictureBox1.Image = result;