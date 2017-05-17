function qwynikowe = kinInvCw3(Pzadane)
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

%sprawdzenie poprawnosci wprowadzonych danych
if (sqrt(pom1) > 250) 
        % a1+a2=500+250=750   a1-a2=250
         %albo fi albo th rozne od 0 wtedy error
        fprintf('\nwprowadzono bledne dane -> punkt P poza zasiegiem robota, lub fi albo th nierowne 0') 
else

    %tu wklejam gotowe rownania ze skruptu, tzn tylko 4 macierz dla 4 przegubu Pnum(:,,4)
    th1num =   [    atan2(py, px) - atan2(-150*(1 - (px^2 + py^2 - 32500)^2/900000000)^(1/2), px^2/200 + py^2/200 - 125/2);
  atan2(py, px) - atan2(150*(1 - (px^2 + py^2 - 32500)^2/900000000)^(1/2), px^2/200 + py^2/200 - 125/2)];
 
    th2num= [   pi + acos(- px^2/30000 - py^2/30000 + 13/12);
 pi - acos(- px^2/30000 - py^2/30000 + 13/12)];
 
 

%      wybor rozwiazania
%       zamiana na najmniejszy kat i jego kierunek
th1num=th1num*stopni;
th2num=th2num*stopni;
        n=size(th1num,1);
      for k=1:n
          if (abs(th1num(k))>180)
              th1num(k)=th1num(k)-(sign(th1num(k))*360);
          end
      end
      fprintf('\nth1num:\n   %f\n   %f\n',th1num(1),th1num(2))

       n=size(th2num,1);
      for k=1:n
          if (abs(th2num(k))>180)
              th2num(k)=th2num(k)-(sign(th2num(k))*360);
          end
      end
      fprintf('\nth2num:\n   %f\n   %f\n',th2num(1),th2num(2))
%wybor rozwiazania

      m=1;
      suma=abs(th1num(1)) + abs(th2num(1));
      for k =1:n 
          if   ( abs(th1num(k)) + abs(th2num(k))<suma);
              m=k;
          end
      end
      
      
      
      fprintf('\nsumy:\n')
      (th1num+th1num)*stopni
       
      fprintf('\noptymalne rozwiazanie nr %i czyli [stopnie]:\n',m)
        qwynikowe=[th1num(m)    th2num(m) (th1num(m)+th2num(m))]

      %fprintf(' th1=%f   th2=%f   d3=%f   th4=%f\n',th1num(m),th2num(m),d3num,th4num(m))

end
fprintf('\t\t\t[   OK   ]\n')                
end

