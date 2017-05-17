%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

fprintf('\n#### wyznaczanie zmiennych qi do kinInvCw3  ####\n')
            syms px py pz       %zadane P
            eq=Psym(:,2);

fprintf('symboliczne wyznaczanie th2...')
            %th2
            L=simplify(eq(1)^2+eq(2)^2);                   
            fprintf('.')
            P=px^2+py^2;

            R1=L-P;
            th2sym=solve(R1,th2);   %dwa rozw
            th2sym=simplify(th2sym);        
fprintf('[   OK   ]\n')      

fprintf('symboliczne wyznaczanie th1...')
            %th1
            th1sym=sym(zeros(2,1));
            for i=1:2
                beta=atan2(    sin(th2sym(i))*a2  ,      (a1+cos(th2sym(i))*a2)       );
                alfa=atan2(py,px);
                th1sym(i,1)=alfa-beta;  %dwa rozw
                th1sym(i,1)=simplify(th1sym(i,1));
                fprintf('.') 
            end
fprintf('[   OK   ]\n')      


%%%%%%%%%%%%%%%%%%%%%%%
fprintf('numeryczne wyznaczanie th1,th2,d3 i th4...')
            th1num=subs(th1sym,{'a1' 'a2'},{100 150});
            th2num=subs(th2sym,{'a1' 'a2'},{100 150});


            Pzadane0=[             750                    0                  0          0          0          0];
            Pzadane1=[   558.0127       466.5064                -20         0          0          90];
            Pzadane2=[            -250                500                -20           0          0       -90];
            Pzadane3=[                0                    0                  0            0          0          90];       
fprintf('[   OK   ]\n')      

fprintf('#### zakonczono wyznaczanie zmiennych qi do kinInvCw3 ####\n\n')


