close all
clear

%example
ImRGB0 = imread('football.jpg');
ImRGB=ImRGB0;
Rows=size(ImRGB,1);
Columns=size(ImRGB,2);
ImOut=uint8(zeros(Rows,Columns,2));

for R=1: Rows
    for C=1:Columns
    ImRGB(R,C,1)=255-ImRGB(R,C,1);  % Image[i,j].R
    ImRGB(R,C,2)=255-ImRGB(R,C,2); % Image[i,j].G
    ImRGB(R,C,3)=255-ImRGB(R,C,3);  % Image[i,j].B
    end
end

subplot(2,1,1)
imshow(ImRGB0); title('ImRGB');
subplot(2,1,2); 
imshow(ImRGB);  title('test');

%Versión 1
ImRGB=ImRGB0;
for R=1: Rows
    for C=1:Columns
    ImRGB(R,C,1)=255-ImRGB(R,C,1);  % Image[i,j].R
    ImRGB(R,C,2)=255-ImRGB(R,C,2); % Image[i,j].G
    ImRGB(R,C,3)=255-ImRGB(R,C,3);  % Image[i,j].B
    end
end
figure
subplot(2,1,1)
imshow(ImRGB0); title('ImRGB0');
subplot(2,1,2); 
imshow(ImRGB);  title('Version1');


%Versión 2
ImRGB=ImRGB0;
for R=1: Rows
    for C=1:Columns
    ImRGB(R,C,1)=255-ImRGB(R,C,1);  % Image[i,j].R
    end
end
for R=1: Rows
    for C=1:Columns
    ImRGB(R,C,2)=255-ImRGB(R,C,2); % Image[i,j].G
    end
end
for R=1: Rows
    for C=1:Columns
    ImRGB(R,C,3)=255-ImRGB(R,C,3);  % Image[i,j].B
    end
end
figure
subplot(2,1,1)
imshow(ImRGB0); title('Version 2 ImRGB0');
subplot(2,1,2); 
imshow(ImRGB);  title('Version 2');

%Versión 3
ImRGB=ImRGB0;
for C=1:Columns
    for R=1: Rows
    ImRGB(R,C,1)=255-ImRGB(R,C,1);  % Image[i,j].R
    ImRGB(R,C,2)=255-ImRGB(R,C,2); % Image[i,j].G
    ImRGB(R,C,3)=255-ImRGB(R,C,3);  % Image[i,j].B
    end
end
figure
subplot(2,1,1)
imshow(ImRGB0); title('Version 3 ImRGB0');
subplot(2,1,2); 
imshow(ImRGB);  title('Version 3');


%Versión 4
ImRGB=ImRGB0;
for R=1: Rows
    for C=1:Columns
    ImRGB(R,C,1)=255-ImRGB(R,C,1);  % Image[i,j].R
    end
end
for R=Rows :-1:1
    for C=Columns:-1:1
    ImRGB(R,C,2)=255-ImRGB(R,C,2); % Image[i,j].G
    ImRGB(R,C,3)=255-ImRGB(R,C,3);  % Image[i,j].B
    end
end
figure
subplot(2,1,1)
imshow(ImRGB0); title('ImRGB0');
subplot(2,1,2); 
imshow(ImRGB);  title('Version 4');

ImRGB=ImRGB0;
%Versión 5
for R=1:2: Rows -1
    for C=1:2:Columns-1
    ImRGB(R,C,1)=255-ImRGB(R,C,1);  % Image[i,j].R
    ImRGB(R,C,2)=255-ImRGB(R,C,2); % Image[i,j].G
    ImRGB(R,C,3)=255-ImRGB(R,C,3);  % Image[i,j].B
    
    ImRGB(R,C+1,1)=255-ImRGB(R,C+1,1);  % Image[i,j+1].R
    ImRGB(R,C+1,2)=255-ImRGB(R,C+1,2);  % Image[i,j+1].G
    ImRGB(R,C+1,3)=255-ImRGB(R,C+1,3);  % Image[i,j+1].B
    
    ImRGB(R+1,C,1)=255-ImRGB(R+1,C,1);  % Image[i+1,j].R
    ImRGB(R+1,C,2)=255-ImRGB(R+1,C,2);  % Image[i+1,j].G
    ImRGB(R+1,C,3)=255-ImRGB(R+1,C,2);  % Image[i+1,j].B
    
    ImRGB(R+1,C+1,1)=255-ImRGB(R+1,C+1,1);  % Image[i+1,j+1].R
    ImRGB(R+1,C+1,1)=255-ImRGB(R+1,C+1,2);  % Image[i+1,j+1].G
    ImRGB(R+1,C+1,1)=255-ImRGB(R+1,C+1,3);  % Image[i+1,j+1].B
  
    end
end

figure
subplot(2,1,1)
imshow(ImRGB0); title('Version 5 ImRGB0');
subplot(2,1,2); 
imshow(ImRGB);  title('Version 5');