call echo Manzoor you have got super powers! Please dont share it with others! Your magic starts in next 10 secs
call timeout 10
call npm install @angular/cli --global
call ng new KataBabySitterUI --skip-install --routing=true --style=css
call move KataBabySitterUI\* .
call move KataBabySitterUI\e2e .
call move KataBabySitterUI\src .
call mkdir wwwroot
call copy NUL wwwroot\text.txt
call echo Kindly change the  "outputPath": "wwwroot" in angular.json in 60 secs
call timeout 60
call echo Now! Do you want me to add bootstrap and jquery sir?
call timeout 10
call npm install bootstrap jquery
call echo Now! Do you want me to add all components sir?
call timeout 10
call ng g c header -is --skipTests
call ng g c footer -is --skipTests
call ng g c home -is --skipTests
call echo Now! Do you want me to add all services sir?
call timeout 10
call ng g s services/api --skipTests
call echo Now! Do you want me to add all models sir?
call timeout 10
call ng g class models/workTime --skipTests
call echo Now! Do you want me to Build it sir?
call timeout 10
call npm install
call ng build
call echo Now! Atleast you should run the app sir.. I am tired...
call timeout 10
call ng serve
