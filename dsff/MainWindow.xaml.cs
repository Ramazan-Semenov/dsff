using System.Windows;

namespace dsff
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Empl> GetEmpls { get; set; } = new List<Empl>();

        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 150; i++)
            {
                var f = new Empl();
                f.w0 = i.ToString();
                f.w1 = i.ToString();
                f.w2 = i.ToString();
                f.w3 = i.ToString();
                f.w4 = i.ToString();
                f.w5 = i.ToString();
                f.w6 = i.ToString();
                f.w7 = i.ToString();
                f.w8 = i.ToString();
                f.w9 = i.ToString();
                f.w10 = i.ToString();
                f.w11 = i.ToString();
                f.w12 = i.ToString();
                f.w13 = i.ToString();
                f.w14 = i.ToString();
                f.w15 = i.ToString();
                f.w16 = i.ToString();
                f.w17 = i.ToString();
                f.w18 = i.ToString();
                f.w19 = i.ToString();
                f.w20 = i.ToString();
                f.w21 = i.ToString();
                f.w22 = i.ToString();
                f.w23 = i.ToString();
                f.w24 = i.ToString();
                f.w25 = i.ToString();
                f.w26 = i.ToString();
                f.w27 = i.ToString();
                f.w28 = i.ToString();
                f.w29 = i.ToString();
                f.w30 = i.ToString();
                f.w31 = i.ToString();
                f.w32 = i.ToString();
                f.w33 = i.ToString();
                f.w34 = i.ToString();
                f.w35 = i.ToString();
                f.w36 = i.ToString();
                f.w37 = i.ToString();
                f.w38 = i.ToString();
                f.w39 = i.ToString();
                f.w40 = i.ToString();
                f.w41 = i.ToString();
                f.w42 = i.ToString();
                f.w43 = i.ToString();
                f.w44 = i.ToString();
                f.w45 = i.ToString();
                f.w46 = i.ToString();
                f.w47 = i.ToString();
                f.w48 = i.ToString();
                f.w49 = i.ToString();
                f.w50 = i.ToString();
                f.w51 = i.ToString();
                f.w52 = i.ToString();
                f.w53 = i.ToString();
                f.w54 = i.ToString();
                f.w55 = i.ToString();
                f.w56 = i.ToString();
                f.w57 = i.ToString();
                f.w58 = i.ToString();
                f.w59 = i.ToString();
                f.w60 = i.ToString();
                f.w61 = i.ToString();
                f.w62 = i.ToString();
                f.w63 = i.ToString();
                f.w64 = i.ToString();
                f.w65 = i.ToString();
                f.w66 = i.ToString();
                f.w67 = i.ToString();
                f.w68 = i.ToString();
                f.w69 = i.ToString();
                f.w70 = i.ToString();
                f.w71 = i.ToString();
                f.w72 = i.ToString();
                f.w73 = i.ToString();
                f.w74 = i.ToString();
                f.w75 = i.ToString();
                f.w76 = i.ToString();
                f.w77 = i.ToString();
                f.w78 = i.ToString();
                f.w79 = i.ToString();
                f.w80 = i.ToString();
                f.w81 = i.ToString();
                f.w82 = i.ToString();
                f.w83 = i.ToString();
                f.w84 = i.ToString();
                f.w85 = i.ToString();
                f.w86 = i.ToString();
                f.w87 = i.ToString();
                f.w88 = i.ToString();
                f.w89 = i.ToString();
                f.w90 = i.ToString();
                f.w91 = i.ToString();
                f.w92 = i.ToString();
                f.w93 = i.ToString();
                f.w94 = i.ToString();
                f.w95 = i.ToString();
                f.w96 = i.ToString();
                f.w97 = i.ToString();
                f.w98 = i.ToString();
                f.w99 = i.ToString();
                f.w100 = i.ToString();
                f.w101 = i.ToString();
                f.w102 = i.ToString();
                f.w103 = i.ToString();
                f.w104 = i.ToString();
                f.w105 = i.ToString();
                f.w106 = i.ToString();
                f.w107 = i.ToString();
                f.w108 = i.ToString();
                f.w109 = i.ToString();
                f.w110 = i.ToString();
                f.w111 = i.ToString();
                f.w112 = i.ToString();
                f.w113 = i.ToString();
                f.w114 = i.ToString();
                f.w115 = i.ToString();
                f.w116 = i.ToString();
                f.w117 = i.ToString();
                f.w118 = i.ToString();
                f.w119 = i.ToString();
                f.w120 = i.ToString();
                f.w121 = i.ToString();
                f.w122 = i.ToString();
                f.w123 = i.ToString();
                f.w124 = i.ToString();
                f.w125 = i.ToString();
                f.w126 = i.ToString();
                f.w127 = i.ToString();
                f.w128 = i.ToString();
                f.w129 = i.ToString();
                f.w130 = i.ToString();
                f.w131 = i.ToString();
                f.w132 = i.ToString();
                f.w133 = i.ToString();
                f.w134 = i.ToString();
                f.w135 = i.ToString();
                f.w136 = i.ToString();
                f.w137 = i.ToString();
                f.w138 = i.ToString();
                f.w139 = i.ToString();
                f.w140 = i.ToString();
                f.w141 = i.ToString();
                f.w142 = i.ToString();
                f.w143 = i.ToString();
                f.w144 = i.ToString();
                f.w145 = i.ToString();
                f.w146 = i.ToString();
                f.w147 = i.ToString();
                f.w148 = i.ToString();
                f.w149 = i.ToString();
                GetEmpls.Add(f);
                // Debug.WriteLine("f.w" + i + " = i.ToString();");
            }

            DataContext = this;
        }
    }
    public class Empl
    {
        public string w0 { get; set; }
        public string w1 { get; set; }
        public string w2 { get; set; }
        public string w3 { get; set; }
        public string w4 { get; set; }
        public string w5 { get; set; }
        public string w6 { get; set; }
        public string w7 { get; set; }
        public string w8 { get; set; }
        public string w9 { get; set; }
        public string w10 { get; set; }
        public string w11 { get; set; }
        public string w12 { get; set; }
        public string w13 { get; set; }
        public string w14 { get; set; }
        public string w15 { get; set; }
        public string w16 { get; set; }
        public string w17 { get; set; }
        public string w18 { get; set; }
        public string w19 { get; set; }
        public string w20 { get; set; }
        public string w21 { get; set; }
        public string w22 { get; set; }
        public string w23 { get; set; }
        public string w24 { get; set; }
        public string w25 { get; set; }
        public string w26 { get; set; }
        public string w27 { get; set; }
        public string w28 { get; set; }
        public string w29 { get; set; }
        public string w30 { get; set; }
        public string w31 { get; set; }
        public string w32 { get; set; }
        public string w33 { get; set; }
        public string w34 { get; set; }
        public string w35 { get; set; }
        public string w36 { get; set; }
        public string w37 { get; set; }
        public string w38 { get; set; }
        public string w39 { get; set; }
        public string w40 { get; set; }
        public string w41 { get; set; }
        public string w42 { get; set; }
        public string w43 { get; set; }
        public string w44 { get; set; }
        public string w45 { get; set; }
        public string w46 { get; set; }
        public string w47 { get; set; }
        public string w48 { get; set; }
        public string w49 { get; set; }
        public string w50 { get; set; }
        public string w51 { get; set; }
        public string w52 { get; set; }
        public string w53 { get; set; }
        public string w54 { get; set; }
        public string w55 { get; set; }
        public string w56 { get; set; }
        public string w57 { get; set; }
        public string w58 { get; set; }
        public string w59 { get; set; }
        public string w60 { get; set; }
        public string w61 { get; set; }
        public string w62 { get; set; }
        public string w63 { get; set; }
        public string w64 { get; set; }
        public string w65 { get; set; }
        public string w66 { get; set; }
        public string w67 { get; set; }
        public string w68 { get; set; }
        public string w69 { get; set; }
        public string w70 { get; set; }
        public string w71 { get; set; }
        public string w72 { get; set; }
        public string w73 { get; set; }
        public string w74 { get; set; }
        public string w75 { get; set; }
        public string w76 { get; set; }
        public string w77 { get; set; }
        public string w78 { get; set; }
        public string w79 { get; set; }
        public string w80 { get; set; }
        public string w81 { get; set; }
        public string w82 { get; set; }
        public string w83 { get; set; }
        public string w84 { get; set; }
        public string w85 { get; set; }
        public string w86 { get; set; }
        public string w87 { get; set; }
        public string w88 { get; set; }
        public string w89 { get; set; }
        public string w90 { get; set; }
        public string w91 { get; set; }
        public string w92 { get; set; }
        public string w93 { get; set; }
        public string w94 { get; set; }
        public string w95 { get; set; }
        public string w96 { get; set; }
        public string w97 { get; set; }
        public string w98 { get; set; }
        public string w99 { get; set; }
        public string w100 { get; set; }
        public string w101 { get; set; }
        public string w102 { get; set; }
        public string w103 { get; set; }
        public string w104 { get; set; }
        public string w105 { get; set; }
        public string w106 { get; set; }
        public string w107 { get; set; }
        public string w108 { get; set; }
        public string w109 { get; set; }
        public string w110 { get; set; }
        public string w111 { get; set; }
        public string w112 { get; set; }
        public string w113 { get; set; }
        public string w114 { get; set; }
        public string w115 { get; set; }
        public string w116 { get; set; }
        public string w117 { get; set; }
        public string w118 { get; set; }
        public string w119 { get; set; }
        public string w120 { get; set; }
        public string w121 { get; set; }
        public string w122 { get; set; }
        public string w123 { get; set; }
        public string w124 { get; set; }
        public string w125 { get; set; }
        public string w126 { get; set; }
        public string w127 { get; set; }
        public string w128 { get; set; }
        public string w129 { get; set; }
        public string w130 { get; set; }
        public string w131 { get; set; }
        public string w132 { get; set; }
        public string w133 { get; set; }
        public string w134 { get; set; }
        public string w135 { get; set; }
        public string w136 { get; set; }
        public string w137 { get; set; }
        public string w138 { get; set; }
        public string w139 { get; set; }
        public string w140 { get; set; }
        public string w141 { get; set; }
        public string w142 { get; set; }
        public string w143 { get; set; }
        public string w144 { get; set; }
        public string w145 { get; set; }
        public string w146 { get; set; }
        public string w147 { get; set; }
        public string w148 { get; set; }
        public string w149 { get; set; }
    }

}