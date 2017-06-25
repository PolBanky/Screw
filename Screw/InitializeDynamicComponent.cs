// Создание и размещение на форме контролов

using System;
using System.Windows.Forms;
using WinLib;               // using WinLib !!!!!!!!!!!!!

namespace Screw
{
    public partial class aForm1 : aForm
    {
        #region Объявление ссылок на контролы (чтоб видны были издаля)
        PictureBox  pict_01;                            // эскиз шнека в сборе и элементов
        TxtBoxDbl   TBox_1, TBox_2, TBox_3;             // Окна для ввода размеров сечения
        LabelR      lbl_TBox_1, lbl_TBox_2, lbl_TBox_3; // Каменты к окнам ввода
        aLabel      Result_1;                           // Окно результатов расчета
        #endregion

        void InitializeDynamicComponent()
        {
            int gap1 = 1;    // величина промежутка между контролами

            #region PictureBoxes
            //
            // pict_01
            //
            pict_01 = new PictureBox();
            pict_01.Top = gap;          // т.е. коорд Y == 5
            pict_01.Left = gap;         // т.е. коорд X == 5
            pict_01.BorderStyle = BorderStyle.Fixed3D;
            pict_01.Height = 385;
            pict_01.Width = 385;
            pict_01.Image = Screw.Properties.Resources.screw_pic;
            pict_01.TabStop = false;
            pict_01.MouseClick += new MouseEventHandler(pict_01_MouseClick);    // определение обработчика события
            #endregion  // PictureBoxes

            #region TxtBoxDbls and their's labels
            //
            // TBox_1
            //
            TBox_1 = new TxtBoxDbl(pict_01, Place.bottom);  // т.е. ставится к картинке снизу
            TBox_1.TabIndex = 1;
            // lbl_TBox_1
            lbl_TBox_1 = new LabelR(TBox_1, "D, mm");
            //
            // TBox_2
            //
            TBox_2 = new TxtBoxDbl(TBox_1, Place.bottom);
            TBox_2.TabIndex = 2;
            // lbl_TBox_2
            lbl_TBox_2 = new LabelR(TBox_2, "d, mm");
            //
            // TBox_3
            //
            TBox_3 = new TxtBoxDbl(TBox_2, Place.bottom);
            TBox_3.TabIndex = 3;
            // lbl_TBox_3
            lbl_TBox_3 = new LabelR(TBox_3, "S, mm");
            #endregion  // TxtBoxDbls and their's labels

            #region aLabel Result
            //
            // Result_1
            //
            Result_1 = new aLabel(lbl_TBox_1.Right + gap1, TBox_1.Top,  // левый верхний угол
                                pict_01.Right - (lbl_TBox_1.Right + gap1), TBox_3.Bottom - TBox_1.Top); // ширина и высота
            Result_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            #endregion  // aLabel Result
            
            #region Add Controls to Form
            //
            // Add Controls to Form1
            //
            this.Controls.Add(pict_01);
            this.Controls.Add(TBox_1);
            this.Controls.Add(lbl_TBox_1);
            this.Controls.Add(TBox_2);
            this.Controls.Add(lbl_TBox_2);
            this.Controls.Add(TBox_3);
            this.Controls.Add(lbl_TBox_3);
            this.Controls.Add(Result_1);


            #endregion  // Add Controls to Form
        }
        // end of - InitializeDynamicComponent()


    }       // end of - class Form1 : Form
}           // end of - namespace Screw