function qwynikowe = kinInv(Pzadane)
%(c) KUba Miszcz 2015
%fcja zwraca wposlrzedne globalne P, i katy Eulera numerycznie
%%%%%%%%%%%%%fprintf('obliczanie dla konca ostatniego ogniwa wspolrzednych P i katow Eulera dla zadanych qi...')
radianow=pi/180;  stopni=180/pi;
fprintf('zadane P :') 
fprintf(' %i ',Pzadane)
px=Pzadane(1);
py=Pzadane(2);
pz=Pzadane(3);

%zmienne pomocnicze
pom1=px^2+py^2;
a11=100;    a12=50;
a1=sqrt(a11^2+a12^2);
a1=100;
a2=150;
%sprawdzenie poprawnosci wprowadzonych danych
if ( (sqrt(pom1) > (a1+a2)) || (sqrt(pom1) < (a1-a2)) ); 
        % a1+a2=500+250=750   a1-a2=250
         %albo fi albo th rozne od 0 wtedy error
        fprintf('\nwprowadzono bledne dane -> punkt P poza zasiegiem robota, lub fi albo th nierowne 0') 
else

eq =[ 
 cos(th1)*(150*cos(th2) + 100);
 sin(th1)*(150*cos(th2) + 100);
                     150*sin(th2)];

th1=solve(eq(1)-px,th1)
th2=solve(eq(2)-py,th2)

fprintf('\noptymalne rozwiazanie\n')
qwynikowe=[th1*stopni    th2*stopni ];


      %fprintf(' th1=%f   th2=%f   d3=%f   th4=%f\n',th1num(m),th2num(m),d3num,th4num(m))

end
fprintf('\t\t\t[   OK   ]\n')                
end

