n=100;

theta1=zeros(n,1);
theta2=zeros(n,1);
theta4=zeros(n,1);


skok=(360/(n-1));
theta1=transpose([0:skok:360]);
theta2=transpose([0:skok:360]);
theta4=transpose([0:skok:360]);

n=size(theta1,1);  %dla pewnosci
zadaneqi=[theta1 theta2 theta4 ];
P=zeros(3,n);
 for k=1:n
      % zadaneqi=[th1(k) th2(k) th3(k) th4(k) th5(k) th6(k)]    
       temp=kinDirCw2(zadaneqi(k,:));
      P(:,k)=temp(:,1);
 end

plot3(P(1,:),P(2,:),P(3,:))


%PP=kinDirCw2(

