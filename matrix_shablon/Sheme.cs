using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace matrix_shablon
{
    public abstract class Drawer : IDrawer
    {
       
        public abstract void Border(IMatrix m);
        public abstract void CellBorder(IMatrix m, int row, int col);
        public abstract void CellValue(IMatrix m, int row, int col);

    }
  public  class Sheme1:Drawer
    {
      Graphics g;
      int x, y;
     int  h =20;
      Pen pen = new Pen(Color.BlueViolet);
      public Sheme1(Graphics g,int x,int y)
      {
          this.g = g;
          this.x = x;
          this.y = y;
        }

        public override void Border(IMatrix m)
        {
           g.DrawRectangle(pen,x,y,h*m.col_num,h*m.row_num); 
        }

        public override void CellBorder(IMatrix m, int row, int col)
        {
            g.DrawRectangle(pen, x + h*col, y +h*row, h , h); 
        }

        public override void CellValue(IMatrix m, int row, int col)
        {
            string s = m[row, col].ToString();
            Font font = new Font("Arial",12);
            SolidBrush brush = new SolidBrush(Color.CornflowerBlue);
            RectangleF rect = new RectangleF(x + h*col, y +h*row, h , h);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            g.DrawString(s,font,brush,rect,format);
        }

        
    }

  public class Sheme2 : Drawer
  {
     Graphics g;
      int x, y;
     int  h =20;
      Pen pen = new Pen(Color.BlueViolet);
      public Sheme2(Graphics g,int x,int y)
      {
          this.g = g;
          this.x = x;
          this.y = y;
        }

        public override void Border(IMatrix m)
        {
           g.DrawRectangle(pen,x,y,h*m.col_num,h*m.row_num); 
        }

        public override void CellBorder(IMatrix m, int row, int col)
        {
            g.DrawRectangle(pen, x + h*col, y +h*row, h , h); 
        }

        public override void CellValue(IMatrix m, int row, int col)
        {
            string s = m[row, col].ToString();
            Font font = new Font("Arial",12);
            SolidBrush brush = new SolidBrush(Color.CornflowerBlue);
            SolidBrush brush1 = new SolidBrush(Color.Gray);
            RectangleF rect = new RectangleF(x + h*col, y +h*row, h , h);
            RectangleF rect1 = new RectangleF(x + h * col+1, y + h * row+1, h+1, h+1);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            g.DrawString(s, font, brush1, rect1, format);
            g.DrawString(s,font,brush,rect,format);
            
        }

        
  }

  public class Sheme3 : Drawer
  {
     Graphics g;
      int x, y;
     int  h =20;
      Pen pen = new Pen(Color.Black);
      public Sheme3(Graphics g,int x,int y)
      {
          this.g = g;
          this.x = x;
          this.y = y;
        }

        public override void Border(IMatrix m)
        {
           g.DrawRectangle(pen,x,y,h*m.col_num,h*m.row_num); 
        }

        public override void CellBorder(IMatrix m, int row, int col)
        {
            g.DrawRectangle(pen, x + h*col, y +h*row, h , h); 
        }

        public override void CellValue(IMatrix m, int row, int col)
        {
            string s = m[row, col].ToString();
            Font font = new Font("Arial",12);
            SolidBrush brush = new SolidBrush(Color.Black);
            RectangleF rect = new RectangleF(x + h*col, y +h*row, h , h);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            g.DrawString(s,font,brush,rect,format);
            
        }
  }
      public class Sheme4 : Drawer
      {
          Graphics g;
      int x, y;
     int  h =20;
      Pen pen = new Pen(Color.Black);
      public Sheme4(Graphics g,int x,int y)
      {
          this.g = g;
          this.x = x;
          this.y = y;
        }

        public override void Border(IMatrix m)
        {
           g.DrawRectangle(pen,x,y,h*m.col_num,h*m.row_num); 
        }

        public override void CellBorder(IMatrix m, int row, int col)
        {
            g.DrawRectangle(pen, x + h*col, y +h*row, h , h); 
        }

        public override void CellValue(IMatrix m, int row, int col)
        {
            string s = m[row, col].ToString();
            Font font = new Font("Arial",12);
            SolidBrush brush = new SolidBrush(Color.Black);
            SolidBrush brush1 = new SolidBrush(Color.Gray);
            RectangleF rect = new RectangleF(x + h*col, y +h*row, h , h);
            RectangleF rect1 = new RectangleF(x + h * col+1, y + h * row+1, h+1, h+1);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            g.DrawString(s, font, brush1, rect1, format);
            g.DrawString(s,font,brush,rect,format);
            
        }
      }




  }



