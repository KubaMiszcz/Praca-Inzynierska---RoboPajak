%skrypt kuby miszcza do cwiczenia 2 wersja V2 (2015)
%dane wejsciowe z tabelek
%dane symboliczne
fprintf('\n#### wczytywanie danych do cwiczenia 3 ####\n')
clear; %czyszczenie workspace
stopni=180/pi;radianow=pi/180;
syms th1 a1;
syms th2 a2;
%DHmacierz z danymi symbolicznymi
DHsym=[th1       sym('0')   a1              sym('0');
       th2       sym('0')   a2              sym('0')];
%macierz z danymi robota, wym w [mm]
   danerobota=[  a1         a2 ;
                 100       150 ];
                     
%Asym wyznaczanie macierzy Ai symboliczne
            fprintf('symboliczne wyznaczanie macierzy Ai...')
            Asym=sym(zeros(4,4));
            n=size(DHsym,1);
            for i =1: n 
                        th=DHsym(i,1);
                        d=DHsym(i,2);
                        a=DHsym(i,3);
                        alfa=DHsym(i,4);
        %  glowny kod
                        Asym(:,:,i)=[ cos(th),     -cos(alfa)*sin(th),       sin(alfa)*sin(th),        a*cos(th);
                                        sin(th),        cos(alfa)*cos(th),     -sin(alfa)*cos(th),       a*sin(th);
                                              0,                    sin(alfa),                      cos(alfa),                       d;
                                              0,                         0,                                  0,                              1];
                       fprintf('.')
            end
            fprintf('[   OK   ]\n')
    
%Tsym wyznaczanie macierzy Ti symboliczne
            fprintf('symboliczne wyznaczanie macierzy Ti...')
            Tsym=sym(zeros(4,4));
            Tsym(:,:,1)=Asym(:,:,1);
            for i =2: n 
                        Tsym(:,:,i)=Tsym(:,:,i-1)*Asym(:,:,i);
                        Tsym(:,:,i)=simplify(Tsym(:,:,i));
                        fprintf('.')
            end
            fprintf('[   OK   ]\n')
            
%Psym wyznaczanie wektora polozenia P symboliczne
            fprintf('symboliczne wyznaczanie wektorow polozenia Pi...')
            Psym=sym(zeros(1,3));
            for i =1: n 
                for j=1:3
                    Psym(j,i)=Tsym(j,4,i);
                    fprintf('.')
                end
            end
            simplify(Psym);
            fprintf('[   OK   ]\n')

%Eulsym symboliczne wyznaczanie katow Eulera...symboliczne
            fprintf('symboliczne wyznaczanie katow Eulera...')
            Eulsym=sym(zeros(1,3));
            for i =1: n 
               %format katow =>   [fi;    th;   psi]
                    ax=Tsym(1,3,i);    ay=Tsym(2,3,i);    az=Tsym(3,3,i);
                    nx=Tsym(1,1,i);    ny=Tsym(2,1,i);    
                    ox=Tsym(1,2,i);    oy=Tsym(2,2,i);
                    fi=atan2(ay,az);
                    th=atan2(cos(fi)*ax+sin(fi)*ay,az);
                    psi=atan2(-sin(fi)*nx+cos(fi)*ny,   -sin(fi)*ox+cos(fi)*oy);
                    fi=simplify(fi);
                    Eulsym(1,i)=fi;    fprintf('.')
                    th=simplify(th);
                    Eulsym(2,i)=th;    fprintf('.')
                    psi=simplify(psi);
                    Eulsym(3,i)=psi;    fprintf('.')
            end
            fprintf('[   OK   ]\n')
            
 %Pnum wyznaczanie wektora polozenia numerycznie
            fprintf('numeryczne wyznaczanie wektorow polozenia Pi...')
            Pnum=Psym;
            n=size(danerobota,2);
            for i =1: n 
                    Pnum=subs(Pnum,danerobota(1,i),danerobota(2,i));
                    fprintf('.')
            end
            fprintf('[   OK   ]\n')           
            
 %Eulnum wyznaczanie katow eulera numerycznie
            fprintf('numeryczne wyznaczanie wektorow polozenia Pi...')
            Eulnum=Eulsym;
            for i =1: n 
                    Eulnum=subs(Eulnum,danerobota(1,i),danerobota(2,i));
                    fprintf('.')
            end
            fprintf('[   OK   ]\n')       
            
            zadaneqi0=[  0   0    0   0 ];
            zadaneqi1=[30 30 -20 30 ];
            zadaneqi2=[90 90 -20 90  ];

fprintf('#### zakonczono wczytywanie danych cwiczenia 3 ####\n')


