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
            for (int i = 0; i < 15000; i++)
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
            }


            DataContext = this;
        }

        public class Empl
        {
            private string _w0;

            public string w0
            {
                get => _w0; set => _w0 = string.Intern(value ?? "");
            }
            private string _w1;

            public string w1
            {
                get => _w1; set => _w1 = string.Intern(value ?? "");
            }
            private string _w2;

            public string w2
            {
                get => _w2; set => _w2 = string.Intern(value ?? "");
            }
            private string _w3;

            public string w3
            {
                get => _w3; set => _w3 = string.Intern(value ?? "");
            }
            private string _w4;

            public string w4
            {
                get => _w4; set => _w4 = string.Intern(value ?? "");
            }
            private string _w5;

            public string w5
            {
                get => _w5; set => _w5 = string.Intern(value ?? "");
            }
            private string _w6;

            public string w6
            {
                get => _w6; set => _w6 = string.Intern(value ?? "");
            }
            private string _w7;

            public string w7
            {
                get => _w7; set => _w7 = string.Intern(value ?? "");
            }
            private string _w8;

            public string w8
            {
                get => _w8; set => _w8 = string.Intern(value ?? "");
            }
            private string _w9;

            public string w9
            {
                get => _w9; set => _w9 = string.Intern(value ?? "");
            }
            private string _w10;

            public string w10
            {
                get => _w10; set => _w10 = string.Intern(value ?? "");
            }
            private string _w11;

            public string w11
            {
                get => _w11; set => _w11 = string.Intern(value ?? "");
            }
            private string _w12;

            public string w12
            {
                get => _w12; set => _w12 = string.Intern(value ?? "");
            }
            private string _w13;

            public string w13
            {
                get => _w13; set => _w13 = string.Intern(value ?? "");
            }
            private string _w14;

            public string w14
            {
                get => _w14; set => _w14 = string.Intern(value ?? "");
            }
            private string _w15;

            public string w15
            {
                get => _w15; set => _w15 = string.Intern(value ?? "");
            }
            private string _w16;

            public string w16
            {
                get => _w16; set => _w16 = string.Intern(value ?? "");
            }
            private string _w17;

            public string w17
            {
                get => _w17; set => _w17 = string.Intern(value ?? "");
            }
            private string _w18;

            public string w18
            {
                get => _w18; set => _w18 = string.Intern(value ?? "");
            }
            private string _w19;

            public string w19
            {
                get => _w19; set => _w19 = string.Intern(value ?? "");
            }
            private string _w20;

            public string w20
            {
                get => _w20; set => _w20 = string.Intern(value ?? "");
            }
            private string _w21;

            public string w21
            {
                get => _w21; set => _w21 = string.Intern(value ?? "");
            }
            private string _w22;

            public string w22
            {
                get => _w22; set => _w22 = string.Intern(value ?? "");
            }
            private string _w23;

            public string w23
            {
                get => _w23; set => _w23 = string.Intern(value ?? "");
            }
            private string _w24;

            public string w24
            {
                get => _w24; set => _w24 = string.Intern(value ?? "");
            }
            private string _w25;

            public string w25
            {
                get => _w25; set => _w25 = string.Intern(value ?? "");
            }
            private string _w26;

            public string w26
            {
                get => _w26; set => _w26 = string.Intern(value ?? "");
            }
            private string _w27;

            public string w27
            {
                get => _w27; set => _w27 = string.Intern(value ?? "");
            }
            private string _w28;

            public string w28
            {
                get => _w28; set => _w28 = string.Intern(value ?? "");
            }
            private string _w29;

            public string w29
            {
                get => _w29; set => _w29 = string.Intern(value ?? "");
            }
            private string _w30;

            public string w30
            {
                get => _w30; set => _w30 = string.Intern(value ?? "");
            }
            private string _w31;

            public string w31
            {
                get => _w31; set => _w31 = string.Intern(value ?? "");
            }
            private string _w32;

            public string w32
            {
                get => _w32; set => _w32 = string.Intern(value ?? "");
            }
            private string _w33;

            public string w33
            {
                get => _w33; set => _w33 = string.Intern(value ?? "");
            }
            private string _w34;

            public string w34
            {
                get => _w34; set => _w34 = string.Intern(value ?? "");
            }
            private string _w35;

            public string w35
            {
                get => _w35; set => _w35 = string.Intern(value ?? "");
            }
            private string _w36;

            public string w36
            {
                get => _w36; set => _w36 = string.Intern(value ?? "");
            }
            private string _w37;

            public string w37
            {
                get => _w37; set => _w37 = string.Intern(value ?? "");
            }
            private string _w38;

            public string w38
            {
                get => _w38; set => _w38 = string.Intern(value ?? "");
            }
            private string _w39;

            public string w39
            {
                get => _w39; set => _w39 = string.Intern(value ?? "");
            }
            private string _w40;

            public string w40
            {
                get => _w40; set => _w40 = string.Intern(value ?? "");
            }
            private string _w41;

            public string w41
            {
                get => _w41; set => _w41 = string.Intern(value ?? "");
            }
            private string _w42;

            public string w42
            {
                get => _w42; set => _w42 = string.Intern(value ?? "");
            }
            private string _w43;

            public string w43
            {
                get => _w43; set => _w43 = string.Intern(value ?? "");
            }
            private string _w44;

            public string w44
            {
                get => _w44; set => _w44 = string.Intern(value ?? "");
            }
            private string _w45;

            public string w45
            {
                get => _w45; set => _w45 = string.Intern(value ?? "");
            }
            private string _w46;

            public string w46
            {
                get => _w46; set => _w46 = string.Intern(value ?? "");
            }
            private string _w47;

            public string w47
            {
                get => _w47; set => _w47 = string.Intern(value ?? "");
            }
            private string _w48;

            public string w48
            {
                get => _w48; set => _w48 = string.Intern(value ?? "");
            }
            private string _w49;

            public string w49
            {
                get => _w49; set => _w49 = string.Intern(value ?? "");
            }
            private string _w50;

            public string w50
            {
                get => _w50; set => _w50 = string.Intern(value ?? "");
            }
            private string _w51;

            public string w51
            {
                get => _w51; set => _w51 = string.Intern(value ?? "");
            }
            private string _w52;

            public string w52
            {
                get => _w52; set => _w52 = string.Intern(value ?? "");
            }
            private string _w53;

            public string w53
            {
                get => _w53; set => _w53 = string.Intern(value ?? "");
            }
            private string _w54;

            public string w54
            {
                get => _w54; set => _w54 = string.Intern(value ?? "");
            }
            private string _w55;

            public string w55
            {
                get => _w55; set => _w55 = string.Intern(value ?? "");
            }
            private string _w56;

            public string w56
            {
                get => _w56; set => _w56 = string.Intern(value ?? "");
            }
            private string _w57;

            public string w57
            {
                get => _w57; set => _w57 = string.Intern(value ?? "");
            }
            private string _w58;

            public string w58
            {
                get => _w58; set => _w58 = string.Intern(value ?? "");
            }
            private string _w59;

            public string w59
            {
                get => _w59; set => _w59 = string.Intern(value ?? "");
            }
            private string _w60;

            public string w60
            {
                get => _w60; set => _w60 = string.Intern(value ?? "");
            }
            private string _w61;

            public string w61
            {
                get => _w61; set => _w61 = string.Intern(value ?? "");
            }
            private string _w62;

            public string w62
            {
                get => _w62; set => _w62 = string.Intern(value ?? "");
            }
            private string _w63;

            public string w63
            {
                get => _w63; set => _w63 = string.Intern(value ?? "");
            }
            private string _w64;

            public string w64
            {
                get => _w64; set => _w64 = string.Intern(value ?? "");
            }
            private string _w65;

            public string w65
            {
                get => _w65; set => _w65 = string.Intern(value ?? "");
            }
            private string _w66;

            public string w66
            {
                get => _w66; set => _w66 = string.Intern(value ?? "");
            }
            private string _w67;

            public string w67
            {
                get => _w67; set => _w67 = string.Intern(value ?? "");
            }
            private string _w68;

            public string w68
            {
                get => _w68; set => _w68 = string.Intern(value ?? "");
            }
            private string _w69;

            public string w69
            {
                get => _w69; set => _w69 = string.Intern(value ?? "");
            }
            private string _w70;

            public string w70
            {
                get => _w70; set => _w70 = string.Intern(value ?? "");
            }
            private string _w71;

            public string w71
            {
                get => _w71; set => _w71 = string.Intern(value ?? "");
            }
            private string _w72;

            public string w72
            {
                get => _w72; set => _w72 = string.Intern(value ?? "");
            }
            private string _w73;

            public string w73
            {
                get => _w73; set => _w73 = string.Intern(value ?? "");
            }
            private string _w74;

            public string w74
            {
                get => _w74; set => _w74 = string.Intern(value ?? "");
            }
            private string _w75;

            public string w75
            {
                get => _w75; set => _w75 = string.Intern(value ?? "");
            }
            private string _w76;

            public string w76
            {
                get => _w76; set => _w76 = string.Intern(value ?? "");
            }
            private string _w77;

            public string w77
            {
                get => _w77; set => _w77 = string.Intern(value ?? "");
            }
            private string _w78;

            public string w78
            {
                get => _w78; set => _w78 = string.Intern(value ?? "");
            }
            private string _w79;

            public string w79
            {
                get => _w79; set => _w79 = string.Intern(value ?? "");
            }
            private string _w80;

            public string w80
            {
                get => _w80; set => _w80 = string.Intern(value ?? "");
            }
            private string _w81;

            public string w81
            {
                get => _w81; set => _w81 = string.Intern(value ?? "");
            }
            private string _w82;

            public string w82
            {
                get => _w82; set => _w82 = string.Intern(value ?? "");
            }
            private string _w83;

            public string w83
            {
                get => _w83; set => _w83 = string.Intern(value ?? "");
            }
            private string _w84;

            public string w84
            {
                get => _w84; set => _w84 = string.Intern(value ?? "");
            }
            private string _w85;

            public string w85
            {
                get => _w85; set => _w85 = string.Intern(value ?? "");
            }
            private string _w86;

            public string w86
            {
                get => _w86; set => _w86 = string.Intern(value ?? "");
            }
            private string _w87;

            public string w87
            {
                get => _w87; set => _w87 = string.Intern(value ?? "");
            }
            private string _w88;

            public string w88
            {
                get => _w88; set => _w88 = string.Intern(value ?? "");
            }
            private string _w89;

            public string w89
            {
                get => _w89; set => _w89 = string.Intern(value ?? "");
            }
            private string _w90;

            public string w90
            {
                get => _w90; set => _w90 = string.Intern(value ?? "");
            }
            private string _w91;

            public string w91
            {
                get => _w91; set => _w91 = string.Intern(value ?? "");
            }
            private string _w92;

            public string w92
            {
                get => _w92; set => _w92 = string.Intern(value ?? "");
            }
            private string _w93;

            public string w93
            {
                get => _w93; set => _w93 = string.Intern(value ?? "");
            }
            private string _w94;

            public string w94
            {
                get => _w94; set => _w94 = string.Intern(value ?? "");
            }
            private string _w95;

            public string w95
            {
                get => _w95; set => _w95 = string.Intern(value ?? "");
            }
            private string _w96;

            public string w96
            {
                get => _w96; set => _w96 = string.Intern(value ?? "");
            }
            private string _w97;

            public string w97
            {
                get => _w97; set => _w97 = string.Intern(value ?? "");
            }
            private string _w98;

            public string w98
            {
                get => _w98; set => _w98 = string.Intern(value ?? "");
            }
            private string _w99;

            public string w99
            {
                get => _w99; set => _w99 = string.Intern(value ?? "");
            }
            private string _w100;

            public string w100
            {
                get => _w100; set => _w100 = string.Intern(value ?? "");
            }
            private string _w101;

            public string w101
            {
                get => _w101; set => _w101 = string.Intern(value ?? "");
            }
            private string _w102;

            public string w102
            {
                get => _w102; set => _w102 = string.Intern(value ?? "");
            }
            private string _w103;

            public string w103
            {
                get => _w103; set => _w103 = string.Intern(value ?? "");
            }
            private string _w104;

            public string w104
            {
                get => _w104; set => _w104 = string.Intern(value ?? "");
            }
            private string _w105;

            public string w105
            {
                get => _w105; set => _w105 = string.Intern(value ?? "");
            }
            private string _w106;

            public string w106
            {
                get => _w106; set => _w106 = string.Intern(value ?? "");
            }
            private string _w107;

            public string w107
            {
                get => _w107; set => _w107 = string.Intern(value ?? "");
            }
            private string _w108;

            public string w108
            {
                get => _w108; set => _w108 = string.Intern(value ?? "");
            }
            private string _w109;

            public string w109
            {
                get => _w109; set => _w109 = string.Intern(value ?? "");
            }
            private string _w110;

            public string w110
            {
                get => _w110; set => _w110 = string.Intern(value ?? "");
            }
            private string _w111;

            public string w111
            {
                get => _w111; set => _w111 = string.Intern(value ?? "");
            }
            private string _w112;

            public string w112
            {
                get => _w112; set => _w112 = string.Intern(value ?? "");
            }
            private string _w113;

            public string w113
            {
                get => _w113; set => _w113 = string.Intern(value ?? "");
            }
            private string _w114;

            public string w114
            {
                get => _w114; set => _w114 = string.Intern(value ?? "");
            }
            private string _w115;

            public string w115
            {
                get => _w115; set => _w115 = string.Intern(value ?? "");
            }
            private string _w116;

            public string w116
            {
                get => _w116; set => _w116 = string.Intern(value ?? "");
            }
            private string _w117;

            public string w117
            {
                get => _w117; set => _w117 = string.Intern(value ?? "");
            }
            private string _w118;

            public string w118
            {
                get => _w118; set => _w118 = string.Intern(value ?? "");
            }
            private string _w119;

            public string w119
            {
                get => _w119; set => _w119 = string.Intern(value ?? "");
            }
            private string _w120;

            public string w120
            {
                get => _w120; set => _w120 = string.Intern(value ?? "");
            }
            private string _w121;

            public string w121
            {
                get => _w121; set => _w121 = string.Intern(value ?? "");
            }
            private string _w122;

            public string w122
            {
                get => _w122; set => _w122 = string.Intern(value ?? "");
            }
            private string _w123;

            public string w123
            {
                get => _w123; set => _w123 = string.Intern(value ?? "");
            }
            private string _w124;

            public string w124
            {
                get => _w124; set => _w124 = string.Intern(value ?? "");
            }
            private string _w125;

            public string w125
            {
                get => _w125; set => _w125 = string.Intern(value ?? "");
            }
            private string _w126;

            public string w126
            {
                get => _w126; set => _w126 = string.Intern(value ?? "");
            }
            private string _w127;

            public string w127
            {
                get => _w127; set => _w127 = string.Intern(value ?? "");
            }
            private string _w128;

            public string w128
            {
                get => _w128; set => _w128 = string.Intern(value ?? "");
            }
            private string _w129;

            public string w129
            {
                get => _w129; set => _w129 = string.Intern(value ?? "");
            }
            private string _w130;

            public string w130
            {
                get => _w130; set => _w130 = string.Intern(value ?? "");
            }
            private string _w131;

            public string w131
            {
                get => _w131; set => _w131 = string.Intern(value ?? "");
            }
            private string _w132;

            public string w132
            {
                get => _w132; set => _w132 = string.Intern(value ?? "");
            }
            private string _w133;

            public string w133
            {
                get => _w133; set => _w133 = string.Intern(value ?? "");
            }
            private string _w134;

            public string w134
            {
                get => _w134; set => _w134 = string.Intern(value ?? "");
            }
            private string _w135;

            public string w135
            {
                get => _w135; set => _w135 = string.Intern(value ?? "");
            }
            private string _w136;

            public string w136
            {
                get => _w136; set => _w136 = string.Intern(value ?? "");
            }
            private string _w137;

            public string w137
            {
                get => _w137; set => _w137 = string.Intern(value ?? "");
            }
            private string _w138;

            public string w138
            {
                get => _w138; set => _w138 = string.Intern(value ?? "");
            }
            private string _w139;

            public string w139
            {
                get => _w139; set => _w139 = string.Intern(value ?? "");
            }
            private string _w140;

            public string w140
            {
                get => _w140; set => _w140 = string.Intern(value ?? "");
            }
            private string _w141;

            public string w141
            {
                get => _w141; set => _w141 = string.Intern(value ?? "");
            }
            private string _w142;

            public string w142
            {
                get => _w142; set => _w142 = string.Intern(value ?? "");
            }
            private string _w143;

            public string w143
            {
                get => _w143; set => _w143 = string.Intern(value ?? "");
            }
            private string _w144;

            public string w144
            {
                get => _w144; set => _w144 = string.Intern(value ?? "");
            }
            private string _w145;

            public string w145
            {
                get => _w145; set => _w145 = string.Intern(value ?? "");
            }
            private string _w146;

            public string w146
            {
                get => _w146; set => _w146 = string.Intern(value ?? "");
            }
            private string _w147;

            public string w147
            {
                get => _w147; set => _w147 = string.Intern(value ?? "");
            }
            private string _w148;

            public string w148
            {
                get => _w148; set => _w148 = string.Intern(value ?? "");
            }
            private string _w149;

            public string w149
            {
                get => _w149; set => _w149 = string.Intern(value ?? "");
            }
        }

    }
}