
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Spire.Doc;
using Spire.Pdf;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System.IO;

namespace MainForm
{
    public partial class XuatDeThi : Form
    {
        public XuatDeThi()
        {
            InitializeComponent();
        }

        

        private void XuatDeThi_Load(object sender, EventArgs e)
        {
            cbSoDe.SelectedIndex = cbSoDe.FindStringExact("1 Đề");
            cbThoiGianLamBai.SelectedIndex = cbThoiGianLamBai.FindStringExact("15 phút");
            txtTenDeThi.Text = "";
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtDuongDan.Text==null|| txtDuongDan.Text=="")
            {
                MessageBox.Show("bạn chưa chọn đường dẫn");
            }
            else
            {
                if (txtTenDeThi.Text == null||txtTenDeThi.Text=="")
                {
                    MessageBox.Show("bạn chưa nhập tên đề thi");
                }
                else
                {
                    XuatFile(SoanCauHoi.listCauHoi);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = txtTenDeThi.Text;
            save.ShowDialog();
            txtDuongDan.Text = save.FileName;
        }

       private int SoDeXuat()
        {
            if(cbSoDe.Text== "1 Đề")
            {
                return 1;
            }
            if (cbSoDe.Text == "2 Đề")
            {
                return 2;
            }
            if (cbSoDe.Text == "3 Đề")
            {
                return 3;
            }
            if (cbSoDe.Text == "4 Đề")
            {
                return 4;
            }
            if (cbSoDe.Text == "5 Đề")
            {
                return 5;
            }
            if (cbSoDe.Text == "6 Đề")
            {
                return 6;
            }
            if (cbSoDe.Text == "7 Đề")
            {
                return 7;
            }
            if (cbSoDe.Text == "8 Đề")
            {
                return 8;
            }
            if (cbSoDe.Text == "9 Đề")
            {
                return 9;

            }
            if (cbSoDe.Text == "10 Đề")
            {
                return 10;
            }
            return 0;
        }

        public void XuatFile(List<Object> listCauHoi)
        {
            String[] strPhan = { "I", "II", "III", "IV", "V", "VI", "VII" };
            String[] strThuTu = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int phan = 0;//số phần trong đề thi

            
            int sodethi = SoDeXuat();
            int cursodethi = 0;
            //tạo file đề thi
            // Tạo đối tượng tài liệu (Document)
            while(cursodethi< sodethi)
            {
                List<CauHoi_1> listCauhoi1 = new List<CauHoi_1>();//đúng nhất
                List<CauHoi_2> listCauhoi2 = new List<CauHoi_2>();//đúng sai
                List<CauHoi_3> listCauhoi3 = new List<CauHoi_3>();//điền chổ trống
                List<CauHoi_4> listCauhoi4 = new List<CauHoi_4>();//ghép nối
                List<CauHoi_5> listCauhoi5 = new List<CauHoi_5>();//trả lời ngắn
                List<CauHoi_6> listCauhoi6 = new List<CauHoi_6>();//sắp xếp
                List<CauHoi_7> listCauhoi7 = new List<CauHoi_7>();//một đáp án

                foreach (var item in listCauHoi)
                {
                    if ((((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0]).GetType().ToString() == "MainForm.CauHoi_1")
                    {
                        //MessageBox.Show((((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0]).GetType().ToString());
                        CauHoi_1 temp = ((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0] as CauHoi_1;
                        if (temp.loaiCauHoi == 1)
                        {
                            listCauhoi1.Add(temp);

                        }
                       
                      
                    }
                    if ((((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0]).GetType().ToString() == "MainForm.CauHoi_2")
                    {
                        CauHoi_2 temp = ((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0] as CauHoi_2;
                        if (temp.loaiCauHoi == 2)
                        {
                            listCauhoi2.Add(temp);


                        }
                    }
                  
                    if ((((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0]).GetType().ToString() == "MainForm.CauHoi_3")
                    {
                        //MessageBox.Show((((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0]).GetType().ToString());
                        CauHoi_3 temp = ((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0] as CauHoi_3;
                        if (temp.loaiCauHoi == 3)
                        {
                            listCauhoi3.Add(temp);


                        }
                    }
                    if ((((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0]).GetType().ToString() == "MainForm.CauHoi_4")
                    {
                        //MessageBox.Show((((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0]).GetType().ToString());
                        CauHoi_4 temp = ((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0] as CauHoi_4;
                        if (temp.loaiCauHoi == 4)
                        {
                            listCauhoi4.Add(temp);


                        }
                    }
                    if ((((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0]).GetType().ToString() == "MainForm.CauHoi_5")
                    {
                        //MessageBox.Show((((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0]).GetType().ToString());
                        CauHoi_5 temp = ((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0] as CauHoi_5;
                        if (temp.loaiCauHoi == 5)
                        {
                            listCauhoi5.Add(temp);


                        }
                    }
                    if ((((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0]).GetType().ToString() == "MainForm.CauHoi_6")
                    {
                        //MessageBox.Show((((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0]).GetType().ToString());
                        CauHoi_6 temp = ((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0] as CauHoi_6;
                        if (temp.loaiCauHoi == 6)
                        {
                            listCauhoi6.Add(temp);


                        }
                    }
                    if ((((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0]).GetType().ToString() == "MainForm.CauHoi_7")
                    {
                        CauHoi_7 temp = ((DevComponents.DotNetBar.ExpandablePanel)item).Controls[0] as CauHoi_7;
                        if (temp.loaiCauHoi == 7)
                        {
                            listCauhoi7.Add(temp);


                        }
                    }

                }

                Document doc = new Document();
                Document docDa = new Document();//file đáp án

                // Tạo đối tượng đoạn (Paragraph)
                Paragraph paragraph = doc.AddSection().AddParagraph();

                Paragraph paragraphDa = docDa.AddSection().AddParagraph();

                // Tên đề thi
                Spire.Doc.Fields.TextRange text = paragraph.AppendText(txtTenDeThi.Text);
                text.CharacterFormat.Bold = true;
                text.CharacterFormat.FontSize = 28;

                // Tên đề thi--đáp án
                Spire.Doc.Fields.TextRange textDa = paragraphDa.AppendText(txtTenDeThi.Text);
                textDa.CharacterFormat.Bold = true;
                textDa.CharacterFormat.FontSize = 28;

                //thời gian làm bài
                Spire.Doc.Fields.TextRange text1 = paragraph.AppendText("\nThời gian làm bài:" + cbThoiGianLamBai.Text);
                text1.CharacterFormat.Bold = false;
                text1.CharacterFormat.FontSize = 15;

                Spire.Doc.Fields.TextRange text1Da = paragraphDa.AppendText("\nThời gian làm bài:" + cbThoiGianLamBai.Text);
                text1Da.CharacterFormat.Bold = false;
                text1Da.CharacterFormat.FontSize = 15;

                //môn học
                Spire.Doc.Fields.TextRange text2 = paragraph.AppendText("\nMôn học: ");
                text2.CharacterFormat.Bold = false;
                text2.CharacterFormat.FontSize = 15;

                Spire.Doc.Fields.TextRange text2Da = paragraphDa.AppendText("\nMôn học: ");
                text2Da.CharacterFormat.Bold = false;
                text2Da.CharacterFormat.FontSize = 15;

                //ngày thi
                Spire.Doc.Fields.TextRange text3 = paragraph.AppendText("\nNgày thi: " + String.Format("{0:dd/MM/yyyy}", NgayThi.Value));
                text3.CharacterFormat.Bold = false;
                text3.CharacterFormat.FontSize = 15;

                Spire.Doc.Fields.TextRange text3Da = paragraphDa.AppendText("\nNgày thi: " + String.Format("{0:dd/MM/yyyy}", NgayThi.Value));
                text3Da.CharacterFormat.Bold = false;
                text3Da.CharacterFormat.FontSize = 15;

                Spire.Doc.Fields.TextRange text4 = paragraph.AppendText("\nĐề "+(cursodethi+1).ToString());
                text4.CharacterFormat.Bold = true;
                text4.CharacterFormat.FontSize = 15;

                Spire.Doc.Fields.TextRange text4Da = paragraphDa.AppendText("\nĐề " + (cursodethi + 1).ToString());
                text4Da.CharacterFormat.Bold = true;
                text4Da.CharacterFormat.FontSize = 15;

                //text.CharacterFormat.Italic = true;  // in nghiêng
                //text.CharacterFormat.UnderlineStyle = UnderlineStyle.Single; // gạch chân

                // kiểu in đậm
                paragraph.Format.TextAlignment = TextAlignment.Center;              // văn bản canh giữa 
                paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;  // đoạn canh giữa
                                                                                                        //paragraph.Format.HorizontalAlignment = HorizontalAlignment.Left;  // đoạn canh trái  
                                                                                                        //paragraph.Format.HorizontalAlignment = HorizontalAlignment.Right; // đoạn canh phải

                ParagraphStyle style = new ParagraphStyle(doc);
                style.Name = "FontStyle";
                style.CharacterFormat.FontName = "Times New Roman";
                style.CharacterFormat.FontSize = 13;
                doc.Styles.Add(style);
                paragraph.ApplyStyle(style.Name);

                ParagraphStyle styleDa = new ParagraphStyle(docDa);
                styleDa.Name = "FontStyle";
                styleDa.CharacterFormat.FontName = "Times New Roman";
                styleDa.CharacterFormat.FontSize = 13;
                docDa.Styles.Add(styleDa);
                paragraphDa.ApplyStyle(styleDa.Name);

                paragraphDa.Format.TextAlignment = TextAlignment.Center;              // văn bản canh giữa 
                paragraphDa.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;  // đoạn canh giữa

                //Phần 1 - chọn câu câu trả lời đúng nhất
                // Tạo đối tượng đoạn (Paragraph)
                int cauHoi = 0;//số câu hỏi
                if (listCauhoi1.Count > 0)
                {
                    
                    // đoạn mới tên biến là  paragraph1
                    Paragraph paragraph1 = doc.Sections[0].AddParagraph();
                    Paragraph paragraph1Da = docDa.Sections[0].AddParagraph();
                    // tên văn bản mới là text1
                    Spire.Doc.Fields.TextRange textPhan1 = paragraph1.AppendText("\nPhần " + strPhan[phan++] + ": Chọn câu trả lời đúng nhất");
                    textPhan1.CharacterFormat.Bold = true;

                    Spire.Doc.Fields.TextRange textPhan1Da = paragraph1Da.AppendText("\nPhần " + strPhan[phan-1] + ": Chọn câu trả lời đúng nhất");
                    textPhan1Da.CharacterFormat.Bold = true;

                    //vẽ bảng đáp án
                    // Dữ liệu mẫu
                    List<int[]> listDa = new List<int[]>();
                    int cot = 0;
                    int dong = listCauhoi1.Count;
                    // Tạo đối tượng bảng Table
                    Spire.Doc.Table table = docDa.Sections[0].AddTable(true);

     
                    
                    while (listCauhoi1.Count > 0)
                    {
                        Random rnd = new Random();
                        int current = rnd.Next(0, listCauhoi1.Count);

                        Spire.Doc.Fields.TextRange textNoiDung = paragraph1.AppendText("\nCâu" + ++cauHoi + ". " + listCauhoi1[current].txtCauHoi.Text);
                        
                        if (listCauhoi1[current].listDapAn.Count > 0)
                        {
                            cot = (cot > listCauhoi1[current].listDapAn.Count) ? cot : listCauhoi1[current].listDapAn.Count;
                            List<GroupBox> lisdapan = new List<GroupBox>();
                            foreach (GroupBox item in listCauhoi1[current].listDapAn)
                            {
                                lisdapan.Add(item);
                            }
                            int dapan = 0;
                            int[] strDa = new int[lisdapan.Count];
                            while (lisdapan.Count > 0)
                            {
                                Random rdapan = new Random();
                                int curDapAn = rdapan.Next(0, lisdapan.Count);
                                Spire.Doc.Fields.TextRange textDapAn = paragraph1.AppendText("\n" + strThuTu[dapan++] + ". " + lisdapan[curDapAn].Controls[0].Text);
                                
                                if (((DevComponents.DotNetBar.Controls.SwitchButton)lisdapan[curDapAn].Controls[1]).Value == true)
                                {
                                    strDa[dapan - 1] = 1;
                                }
                                else
                                {
                                    strDa[dapan - 1] = 0;
                                }
                                lisdapan.RemoveAt(curDapAn);
                            }
                            listDa.Add(strDa);

                        }
                        listCauhoi1.RemoveAt(current);
                    }

                    // Số dòng và số cột cho bảng
                    table.ResetCells(dong+1, cot+1);

                    

                    // Tạo dòng tiêu đề cho bảng (dòng 0)
                    Spire.Doc.TableRow FRow = table.Rows[0];
                    FRow.IsHeader = true;
                    FRow.Height = 23;

                    for (int i = 1; i <= cot; i++)
                    {
                        // Định dạng cell
                        Paragraph p = FRow.Cells[i].AddParagraph();
                        FRow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                        // Định dạng văn bản trong bảng
                        Spire.Doc.Fields.TextRange TR = p.AppendText(strThuTu[i-1]);
                        TR.CharacterFormat.FontName = "Times New Roman";
                        TR.CharacterFormat.FontSize = 13;
                        TR.CharacterFormat.Bold = true;
                    }

                    // Định dạng dữ liệu từng dòng (lấy từ listDa)
                    for (int r = 1; r <= dong; r++)
                    {
                        

                        // Định dạng dòng thứ r (bỏ dòng đầu là tiêu đề)
                        Spire.Doc.TableRow DataRow = table.Rows[r];
                        Paragraph p = DataRow.Cells[0].AddParagraph();
                        DataRow.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        // Định dạng văn bản trong bảng
                        Spire.Doc.Fields.TextRange TR = p.AppendText("Câu "+r);

                        for(int i=0;i<listDa[r-1].Length;i++)
                        {
                            if(listDa[r - 1][i]==1)
                            {
                                DataRow.Cells[i+1].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                                Paragraph p1 = DataRow.Cells[i+1].AddParagraph();
                                Spire.Doc.Fields.TextRange TR1 = p1.AppendText("X"); // 
                                p1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                            }
                        }


                        

                        
                    }

                }


                //Phần 2 - chọn câu câu trả lời đúng 
                if (listCauhoi7.Count > 0)
                {
                    // đoạn mới tên biến là  paragraph1
                    Paragraph paragraph1 = doc.Sections[0].AddParagraph();
                    // tên văn bản mới là text1
                    Spire.Doc.Fields.TextRange textPhan1 = paragraph1.AppendText("\nPhần " + strPhan[phan++] + ": Đánh dấu câu trả lời đúng");
                    textPhan1.CharacterFormat.Bold = true;

                    Paragraph paragraph1Da = docDa.Sections[0].AddParagraph();
                    Spire.Doc.Fields.TextRange textPhan1Da = paragraph1Da.AppendText("\nPhần " + strPhan[phan-1] + ": Chọn câu trả lời đúng");
                    textPhan1Da.CharacterFormat.Bold = true;

                    //vẽ bảng đáp án
                    // Dữ liệu mẫu
                    List<int[]> listDa = new List<int[]>();
                    int cot = 0;
                    int dong = listCauhoi7.Count;
                    // Tạo đối tượng bảng Table
                    Spire.Doc.Table table = docDa.Sections[0].AddTable(true);

                    while (listCauhoi7.Count > 0)
                    {
                        Random rnd = new Random();
                        int current = rnd.Next(0, listCauhoi7.Count);

                        Spire.Doc.Fields.TextRange textNoiDung = paragraph1.AppendText("\nCâu" + ++cauHoi + ". " + listCauhoi7[current].txtCauHoi.Text);
                        cot = (cot > listCauhoi7[current].listDapAn.Count) ? cot : listCauhoi7[current].listDapAn.Count;
                        if (listCauhoi7[current].listDapAn.Count > 0)
                        {
                            List<GroupBox> lisdapan = new List<GroupBox>();
                            foreach (GroupBox item in listCauhoi7[current].listDapAn)
                            {
                                lisdapan.Add(item);
                            }
                            int dapan = 0;
                            int[] strDa = new int[lisdapan.Count];
                            while (lisdapan.Count > 0)
                            {
                                Random rdapan = new Random();
                                int curDapAn = rdapan.Next(0, lisdapan.Count);

                                Spire.Doc.Fields.TextRange textDapAn = paragraph1.AppendText("\n" + strThuTu[dapan++] + ". " + lisdapan[curDapAn].Controls[0].Text);

                                if (((DevComponents.DotNetBar.Controls.SwitchButton)lisdapan[curDapAn].Controls[1]).Value == true)
                                {
                                    strDa[dapan - 1] = 1;
                                }
                                else
                                {
                                    strDa[dapan - 1] = 0;
                                }
                                lisdapan.RemoveAt(curDapAn);
                            }
                            listDa.Add(strDa);
                        }
                        listCauhoi7.RemoveAt(current);
                    }

                    // Số dòng và số cột cho bảng
                    table.ResetCells(dong + 1, cot + 1);



                    // Tạo dòng tiêu đề cho bảng (dòng 0)
                    Spire.Doc.TableRow FRow = table.Rows[0];
                    FRow.IsHeader = true;
                    FRow.Height = 23;

                    for (int i = 1; i <= cot; i++)
                    {
                        // Định dạng cell
                        Paragraph p = FRow.Cells[i].AddParagraph();
                        FRow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                        // Định dạng văn bản trong bảng
                        Spire.Doc.Fields.TextRange TR = p.AppendText(strThuTu[i - 1]);
                        TR.CharacterFormat.FontName = "Times New Roman";
                        TR.CharacterFormat.FontSize = 13;
                        TR.CharacterFormat.Bold = true;
                    }

                    // Định dạng dữ liệu từng dòng (lấy từ listDa)
                    for (int r = 1; r <= dong; r++)
                    {


                        // Định dạng dòng thứ r (bỏ dòng đầu là tiêu đề)
                        Spire.Doc.TableRow DataRow = table.Rows[r];
                        Paragraph p = DataRow.Cells[0].AddParagraph();
                        DataRow.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        // Định dạng văn bản trong bảng
                        Spire.Doc.Fields.TextRange TR = p.AppendText("Câu " + r);

                        for (int i = 0; i < listDa[r - 1].Length; i++)
                        {
                            if (listDa[r - 1][i] == 1)
                            {
                                DataRow.Cells[i + 1].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                                Paragraph p1 = DataRow.Cells[i + 1].AddParagraph();
                                Spire.Doc.Fields.TextRange TR1 = p1.AppendText("X"); // 
                                p1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                            }
                        }

                    }
                }
                //Phần 3 - nhận định đúng sai
                int tablenuber = 0;//số bảng sử dụng
                if (listCauhoi2.Count > 0)
                {
                    // đoạn mới tên biến là  paragraph1
                    Paragraph paragraph1 = doc.Sections[0].AddParagraph();
                    // tên văn bản mới là text1
                    Spire.Doc.Fields.TextRange textPhan1 = paragraph1.AppendText("\nPhần " + strPhan[phan++] + ": Nhận định đúng sai");
                    textPhan1.CharacterFormat.Bold = true;

                    Paragraph paragraph1Da = docDa.Sections[0].AddParagraph();
                    Spire.Doc.Fields.TextRange textPhan1Da = paragraph1Da.AppendText("\nPhần " + strPhan[phan - 1] + ": Nhận định đúng sai");
                    textPhan1Da.CharacterFormat.Bold = true;

                    while (listCauhoi2.Count > 0)
                    {
                        Paragraph paragraph2 = doc.Sections[0].AddParagraph();
                        Paragraph paragraph2Da = docDa.Sections[0].AddParagraph();
                        Random rnd = new Random();
                        int current = rnd.Next(0, listCauhoi2.Count);

                        Spire.Doc.Fields.TextRange textNoiDung = paragraph2.AppendText("\nCâu" + ++cauHoi + ". " + listCauhoi2[current].txtCauHoi.Text);
                        Spire.Doc.Fields.TextRange textNoiDungDa = paragraph2Da.AppendText("\nCâu" + (cauHoi) + ". " + listCauhoi2[current].txtCauHoi.Text);
                        if (listCauhoi2[current].listDapAn.Count > 0)
                        {
                            List<GroupBox> lisdapan = new List<GroupBox>();
                            foreach (GroupBox item in listCauhoi2[current].listDapAn)
                            {
                                lisdapan.Add(item);
                            }
                            int dapan = 0;

                            // Dữ liệu mẫu
                            List<string> list = new List<string>();
                            List<int> listDa = new List<int>();
                            while (lisdapan.Count > 0)
                            {
                                Random rdapan = new Random();
                                int curDapAn = rdapan.Next(0, lisdapan.Count);
                                list.Add(strThuTu[dapan++] + ". " + lisdapan[curDapAn].Controls[0].Text);
                                if(((DevComponents.DotNetBar.Controls.SwitchButton)lisdapan[curDapAn].Controls[1]).Value==true)
                                {
                                    listDa.Add(1);
                                }
                                else
                                {
                                    listDa.Add(0);
                                }
                                lisdapan.RemoveAt(curDapAn);
                            }

                            // Tạo đối tượng bảng Table
                            Spire.Doc.Table table = doc.Sections[0].AddTable(true);
                            Spire.Doc.Table tableDa = docDa.Sections[0].AddTable(true);


                            // Tạo cột
                            String[] Header = { "Câu", "Đúng", "Sai" };

                            // Số dòng và số cột cho bảng
                            table.ResetCells(list.Count + 1, Header.Length);
                            tableDa.ResetCells(list.Count + 1, Header.Length);
                            float[] width = { 440.27f, 55.03f, 55.03f };

                            // xóa border

                            table.TableFormat.Borders.Color = Color.White;
                            
                            // Tạo dòng tiêu đề cho bảng (dòng 0)
                            Spire.Doc.TableRow FRow = table.Rows[0];
                            Spire.Doc.TableRow FRowDa = tableDa.Rows[0];

                            FRow.Cells[0].Width = 1000;
                            FRow.Cells[1].CellFormat.Borders.Right.Color = Color.Black;

                            FRowDa.Cells[0].Width = 1000;


                            for (int i = 0; i < Header.Length; i++)
                            {
                                // Định dạng cell

                                Paragraph p = FRow.Cells[i].AddParagraph();
                                FRow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                                p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                                FRow.Cells[i].CellFormat.Borders.Color = Color.White;

                                // Định dạng văn bản trong bảng
                                Spire.Doc.Fields.TextRange TR = p.AppendText(Header[i]);
                                TR.CharacterFormat.FontName = "Times New Roman";
                                TR.CharacterFormat.FontSize = 13;
                                TR.CharacterFormat.Bold = true;

                                Paragraph pDa = FRowDa.Cells[i].AddParagraph();
                                FRowDa.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                                pDa.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                                // Định dạng văn bản trong bảng
                                Spire.Doc.Fields.TextRange TRDa = pDa.AppendText(Header[i]);
                                TRDa.CharacterFormat.FontName = "Times New Roman";
                                TRDa.CharacterFormat.FontSize = 13;
                                TRDa.CharacterFormat.Bold = true;
                            }

                            // Định dạng dữ liệu từng dòng (lấy từ list)
                            for (int r = 0; r < list.Count; r++)
                            {

                                // Định dạng dòng thứ r + 1 (bỏ dòng đầu là tiêu đề)
                                Spire.Doc.TableRow DataRow = table.Rows[r + 1];
                                DataRow.RowFormat.Borders.Color = Color.White;

                                DataRow.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                                Paragraph p1 = DataRow.Cells[0].AddParagraph();
                                Spire.Doc.Fields.TextRange TR1 = p1.AppendText(list[r].ToString()); // câu hỏi
                                p1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;
                                DataRow.Cells[0].CellFormat.Borders.Color = Color.White;

                                DataRow.Cells[1].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                                Paragraph p2 = DataRow.Cells[1].AddParagraph();
                                Spire.Doc.Fields.TextRange TR2 = p2.AppendText("☐"); // đúng
                                p2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                                DataRow.Cells[1].CellFormat.Borders.Color = Color.White;
                                DataRow.Cells[1].CellFormat.Borders.Right.Color = Color.Black;

                                DataRow.Cells[2].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                                Paragraph p3 = DataRow.Cells[2].AddParagraph();
                                Spire.Doc.Fields.TextRange TR3 = p3.AppendText("☐"); // sai
                                p3.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                                DataRow.Cells[2].CellFormat.Borders.Color = Color.White;

                                // Định dạng dòng thứ r + 1 (bỏ dòng đầu là tiêu đề)//đáp án
                                Spire.Doc.TableRow DataRowDa = tableDa.Rows[r + 1];
                                DataRowDa.RowFormat.Borders.Color = Color.White;

                                DataRowDa.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                                Paragraph p1Da = DataRowDa.Cells[0].AddParagraph();
                                Spire.Doc.Fields.TextRange TR1Da = p1Da.AppendText("Câu "+strThuTu[r]); // câu hỏi
                                p1Da.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;
                                

                                DataRowDa.Cells[1].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                                Paragraph p2Da = DataRowDa.Cells[1].AddParagraph();
                                if(listDa[r]==1)
                                {
                                    Spire.Doc.Fields.TextRange TR2Da = p2Da.AppendText("X"); // đúng
                                }
                                
                                p2Da.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                                

                                DataRowDa.Cells[2].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                                Paragraph p3Da = DataRowDa.Cells[2].AddParagraph();
                                if (listDa[r] == 0)
                                {
                                    Spire.Doc.Fields.TextRange TR3Da = p3Da.AppendText("X"); // sai
                                }
                                
                                p3Da.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                                

                            }


                        }
                        listCauhoi2.RemoveAt(current);
                    }
                }
                //Phần 4 - ghép nối
                if (listCauhoi4.Count > 0)
                {
                    // đoạn mới tên biến là  paragraph1
                    Paragraph paragraph1 = doc.Sections[0].AddParagraph();
                    // tên văn bản mới là text1
                    Spire.Doc.Fields.TextRange textPhan1 = paragraph1.AppendText("\nPhần " + strPhan[phan++] + ": Ghép nối");
                    textPhan1.CharacterFormat.Bold = true;

                    Paragraph paragraph1Da = docDa.Sections[0].AddParagraph();
                    Spire.Doc.Fields.TextRange textPhan1Da = paragraph1Da.AppendText("\nPhần " + strPhan[phan - 1] + ": Ghép nối");
                    textPhan1Da.CharacterFormat.Bold = true;

                    while (listCauhoi4.Count > 0)
                    {
                        Random rnd = new Random();
                        int current = rnd.Next(0, listCauhoi4.Count);
                        Paragraph paragraph2 = doc.Sections[0].AddParagraph();
                        Spire.Doc.Fields.TextRange textNoiDung = paragraph2.AppendText("\nCâu" + ++cauHoi + ". " + listCauhoi4[current].txtCauHoi.Text);

                        Paragraph paragraph2Da = docDa.Sections[0].AddParagraph();
                        Spire.Doc.Fields.TextRange textNoiDungDa = paragraph2Da.AppendText("\nCâu" + (cauHoi));

                        if (listCauhoi4[current].DanhSachYGr1.Count > 0)
                        {
                            List<GroupBox> listY1 = new List<GroupBox>();
                            foreach (GroupBox item in listCauhoi4[current].DanhSachYGr1)
                            {
                                listY1.Add(item);
                            }

                            List<GroupBox> listY2 = new List<GroupBox>();
                            foreach (GroupBox item in listCauhoi4[current].DanhSachYGr2)
                            {
                                listY2.Add(item);
                            }

                            List<GroupBox> listDa = new List<GroupBox>();
                            foreach (GroupBox item in listCauhoi4[current].DanhSachDapAnGr)
                            {
                                listDa.Add(item);
                            }

                            // Dữ liệu mẫu
                            List<string> list1 = new List<string>();
                            int Y1 = 0;
                            List<string> listDastr = new List<string>();
                            while (listY1.Count > 0)
                            {
                                Random rdapan = new Random();
                                int curDapAn = rdapan.Next(0, listY1.Count);
                                list1.Add((++Y1).ToString() + ". " + listY1[curDapAn].Controls[0].Text);
                                listDastr.Add((Y1).ToString() + " - " + listDa[curDapAn].Controls[0].Text);
                                listDa.RemoveAt(curDapAn);
                                listY1.RemoveAt(curDapAn);
                            }


                            List<string> list2 = new List<string>();
                            int Y2 = 0;
                            while (listY2.Count > 0)
                            {
                                Random rdapan = new Random();
                                int curDapAn = rdapan.Next(0, listY2.Count);
                                list2.Add(strThuTu[Y2++] + ". " + listY2[0].Controls[0].Text);
                                listY2.RemoveAt(0);
                            }

                            // Tạo đối tượng bảng Table
                            Spire.Doc.Table table = doc.Sections[0].AddTable(true);

                            // Tạo cột
                            String[] Header = { "Nội dung 1", "Nội dung 2" };

                            // Số dòng và số cột cho bảng
                            table.ResetCells(2, Header.Length);



                            // Tạo dòng tiêu đề cho bảng (dòng 0)
                            Spire.Doc.TableRow FRow = table.Rows[0];
                            FRow.IsHeader = true;
                            FRow.Height = 23;

                            for (int i = 0; i < Header.Length; i++)
                            {
                                // Định dạng cell
                                Paragraph p = FRow.Cells[i].AddParagraph();
                                FRow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                                p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                                // Định dạng văn bản trong bảng
                                Spire.Doc.Fields.TextRange TR = p.AppendText(Header[i]);
                                TR.CharacterFormat.FontName = "Times New Roman";
                                TR.CharacterFormat.FontSize = 13;
                                TR.CharacterFormat.Bold = true;
                            }

                            // Định dạng dữ liệu từng dòng (lấy từ list1)
                            for (int r = 0; r < list1.Count; r++)
                            {


                                // Định dạng dòng thứ r + 1 (bỏ dòng đầu là tiêu đề)
                                Spire.Doc.TableRow DataRow = table.Rows[1];


                                DataRow.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Top;
                                Paragraph p1 = DataRow.Cells[0].AddParagraph();
                                Spire.Doc.Fields.TextRange TR1 = p1.AppendText(list1[r].ToString() + "\n"); // nội dung 1
                                p1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;


                            }
                            for (int r = 0; r < list2.Count; r++)
                            {


                                // Định dạng dòng thứ r + 1 (bỏ dòng đầu là tiêu đề)
                                Spire.Doc.TableRow DataRow = table.Rows[1];


                                DataRow.Cells[1].CellFormat.VerticalAlignment = VerticalAlignment.Top;
                                Paragraph p1 = DataRow.Cells[1].AddParagraph();
                                Spire.Doc.Fields.TextRange TR1 = p1.AppendText(list2[r].ToString() + "\n"); // nội dung 2
                                p1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;


                            }

                            Paragraph paragraph3 = doc.Sections[0].AddParagraph();
                            Spire.Doc.Fields.TextRange textdapan = paragraph3.AppendText("Đáp án");

                            Paragraph paragraph3Da = docDa.Sections[0].AddParagraph();
                            
                            for (int r = 0; r < list1.Count; r++)
                            {

                                Spire.Doc.Fields.TextRange textdapanN = paragraph3.AppendText("\n" + (r + 1).ToString() + ": " + "............................");
                                Spire.Doc.Fields.TextRange textdapanNDa = paragraph3Da.AppendText("\n" + listDastr[r] );

                            }
                            phan = 0;
                        }




                        listCauhoi4.RemoveAt(current);
                    }
                }
                //Phần 5 - sắp xếp
                if (listCauhoi6.Count > 0)
                {
                    // đoạn mới tên biến là  paragraph1
                    Paragraph paragraph1 = doc.Sections[0].AddParagraph();
                    // tên văn bản mới là text1
                    Spire.Doc.Fields.TextRange textPhan1 = paragraph1.AppendText("\nPhần " + strPhan[phan++] + ": Sắp xếp");
                    textPhan1.CharacterFormat.Bold = true;

                    Paragraph paragraph1Da = docDa.Sections[0].AddParagraph();
                    Spire.Doc.Fields.TextRange textPhan1Da = paragraph1Da.AppendText("\nPhần " + strPhan[phan - 1] + ": Sắp xếp");
                    textPhan1Da.CharacterFormat.Bold = true;

                    while (listCauhoi6.Count > 0)
                    {
                        Random rnd = new Random();
                        int current = rnd.Next(0, listCauhoi6.Count);

                        Spire.Doc.Fields.TextRange textNoiDung = paragraph1.AppendText("\nCâu" + ++cauHoi + ". " + listCauhoi6[current].txtCauHoi.Text);
                        Spire.Doc.Fields.TextRange textNoiDungDa = paragraph1Da.AppendText("\nCâu" + cauHoi );
                        if (listCauhoi6[current].DanhSachYGr.Count > 0)
                        {
                            List<GroupBox> listY = new List<GroupBox>();
                            List<GroupBox> listDa = new List<GroupBox>();
                            foreach (GroupBox item in listCauhoi6[current].DanhSachYGr)
                            {
                                listY.Add(item);

                            }
                            foreach (GroupBox item in listCauhoi6[current].DanhSachDapAnGr)
                            {
                                listDa.Add(item);

                            }
                            int dapan = 0;
                            string dapanDa = "";
                            while (listY.Count > 0)
                            {
                                Random rdapan = new Random();
                                int curY = rdapan.Next(0, listY.Count);

                                Spire.Doc.Fields.TextRange textY = paragraph1.AppendText("\n" + strThuTu[dapan++].ToString() + ". " + listY[0].Controls[0].Text);
                                dapanDa += listDa[0].Controls[0].Text;
                                listDa.RemoveAt(0);
                                listY.RemoveAt(0);
                                if (listY.Count > 0)
                                    dapanDa += " - ";
                            }
                            Spire.Doc.Fields.TextRange textDapAn = paragraph1.AppendText("\nThứ tự đúng: .........................................");
                            Spire.Doc.Fields.TextRange textDapAnDa = paragraph1Da.AppendText("\n"+ dapanDa);
                        }
                        listCauhoi6.RemoveAt(current);
                    }
                }
                //Phần 6 - điền khuyết
                if (listCauhoi3.Count > 0)
                {
                    // đoạn mới tên biến là  paragraph1
                    Paragraph paragraph1 = doc.Sections[0].AddParagraph();
                    // tên văn bản mới là text1
                    Spire.Doc.Fields.TextRange textPhan1 = paragraph1.AppendText("\nPhần " + strPhan[phan++] + ": Điền khuyết");
                    textPhan1.CharacterFormat.Bold = true;

                    Paragraph paragraph1Da = docDa.Sections[0].AddParagraph();
                    Spire.Doc.Fields.TextRange textPhan1Da = paragraph1Da.AppendText("\nPhần " + strPhan[phan - 1] + ": Điền khuyết");
                    textPhan1Da.CharacterFormat.Bold = true;

                    while (listCauhoi3.Count > 0)
                    {
                        Random rnd = new Random();
                        int current = rnd.Next(0, listCauhoi3.Count);

                        Spire.Doc.Fields.TextRange textNoiDung = paragraph1.AppendText("\nCâu" + ++cauHoi + ". " + listCauhoi3[current].txtCauHoi.Text);
                        Spire.Doc.Fields.TextRange textNoiDungDa = paragraph1Da.AppendText("\nCâu" + cauHoi );
                        if (listCauhoi3[current].listDapAn.Count > 0)
                        {
                            List<GroupBox> lisdapan = new List<GroupBox>();
                            foreach (GroupBox item in listCauhoi3[current].listDapAn)
                            {
                                lisdapan.Add(item);
                            }
                            int dapan = 0;
                            while (lisdapan.Count > 0)
                            {
                                Random rdapan = new Random();
                                int curDapAn = rdapan.Next(0, lisdapan.Count);

                                Spire.Doc.Fields.TextRange textDapAn = paragraph1.AppendText("\n(" + (++dapan).ToString() + ") .........................................");
                                Spire.Doc.Fields.TextRange textDapAnDa = paragraph1Da.AppendText("\n(" + (dapan).ToString() + ") "+ lisdapan[0].Controls[0].Text);
                                lisdapan.RemoveAt(0);
                            }

                        }
                        listCauhoi3.RemoveAt(current);
                    }

                }
                //Phần 7 - trả lời ngắn
                if (listCauhoi5.Count > 0)
                {
                    // đoạn mới tên biến là  paragraph1
                    Paragraph paragraph1 = doc.Sections[0].AddParagraph();
                    // tên văn bản mới là text1
                    Spire.Doc.Fields.TextRange textPhan1 = paragraph1.AppendText("\nPhần " + strPhan[phan++] + ": Trả lời ngắn");
                    textPhan1.CharacterFormat.Bold = true;

                    Paragraph paragraph1Da = docDa.Sections[0].AddParagraph();
                    Spire.Doc.Fields.TextRange textPhan1Da = paragraph1Da.AppendText("\nPhần " + strPhan[phan - 1] + ": Trả lời ngắn");
                    textPhan1Da.CharacterFormat.Bold = true;

                    while (listCauhoi5.Count > 0)
                    {
                        Random rnd = new Random();
                        int current = rnd.Next(0, listCauhoi6.Count);

                        Spire.Doc.Fields.TextRange textNoiDung = paragraph1.AppendText("\nCâu" + ++cauHoi + ". " + listCauhoi5[current].txtCauHoi.Text);
                        Spire.Doc.Fields.TextRange textdapan = paragraph1.AppendText("\nTrả lời: " +
                            ".........................................................................................................................\n");

                        Spire.Doc.Fields.TextRange textNoiDungDa = paragraph1Da.AppendText("\nCâu" + cauHoi);
                        Spire.Doc.Fields.TextRange textdapanDa = paragraph1Da.AppendText("\n"+ listCauhoi5[current].richDapAn.Text);



                        listCauhoi5.RemoveAt(current);
                    }


                }
                
                //string[] filename=txtDuongDan.Text.Trim().Split(new string[] { @"\" }, StringSplitOptions.RemoveEmptyEntries);
                if(radioButton1.Checked==true)
                {
                    doc.SaveToFile(txtDuongDan.Text +(cursodethi+1).ToString()+".docx", Spire.Doc.FileFormat.Docx);
                    docDa.SaveToFile(txtDuongDan.Text+"DA" + (cursodethi + 1).ToString() + ".docx", Spire.Doc.FileFormat.Docx);
                }

                if(radioButton2.Checked==true)
                {
                    doc.SaveToFile(txtDuongDan.Text  + (cursodethi + 1).ToString() + ".pdf", Spire.Doc.FileFormat.PDF);// -- tạo PDF
                    docDa.SaveToFile(txtDuongDan.Text +"DA" + (cursodethi + 1).ToString() + ".pdf", Spire.Doc.FileFormat.PDF);// -- tạo PDF
                }


                cursodethi += 1;
                // đóng đối tượng
                doc.Close();
                docDa.Close();
            }
            
            this.Dispose();

            
        }
    }
}
