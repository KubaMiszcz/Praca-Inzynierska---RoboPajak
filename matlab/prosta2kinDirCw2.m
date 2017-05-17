function Pwynikowe = kinDirCw2(zadaneqi)
%(c) KUba Miszcz 2015
%fcja zwraca wposlrzedne globalne P, i katy Eulera numerycznie
 %   fprintf('obliczanie dla konca ostatniego ogniwa wspolrzednych P i katow Eulera dla zadanych qi...')
    radianow=pi/180;  stopni=180/pi;
    theta1=zadaneqi(1)*radianow;
    theta2=zadaneqi(2)*radianow;
    theta4=zadaneqi(4)*radianow;

    %tu wklejam gotowe rownania ze skruptu, tzn tylko 6 macierz dla 6 przegubu Pnum(:,:,6)
    Pnum=[   
 cos(theta1)*(150*cos(theta2 + theta4) + 100*cos(theta2) + 50*sin(theta2) + 50);
 sin(theta1)*(150*cos(theta2 + theta4) + 100*cos(theta2) + 50*sin(theta2) + 50);
                    150*sin(theta2 + theta4) - 50*cos(theta2) + 100*sin(theta2)
  ];

    Eulnum=[
                    -(pi*sign(cos(theta1)))/2;
         (pi*sign(cos((pi*sign(cos(theta1)))/2)*sin(theta1) + sin((pi*sign(cos(theta1)))/2)*cos(theta1)))/2;
 atan2(cos((pi*sign(cos(theta1)))/2)*cos(theta2 + theta4)*sin(theta1) + sin((pi*sign(cos(theta1)))/2)*cos(theta2 + theta4)*cos(theta1), - cos((pi*sign(cos(theta1)))/2)*sin(theta2 + theta4)*sin(theta1) - sin((pi*sign(cos(theta1)))/2)*sin(theta2 + theta4)*cos(theta1))
  ];

    Pwynikowe=[double(Pnum),Eulnum*stopni];
%    fprintf('\t\t\t[   OK   ]\n')                
end

