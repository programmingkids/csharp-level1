#! /bin/bash

echo " -- Install .Net Core -- "
sudo yum -y install libunwind
curl -L -O https://dot.net/v1/dotnet-install.sh
sudo chmod u=rx dotnet-install.sh
./dotnet-install.sh --channel latest --version 5.0.208
echo " -- .Net Core is installed -- "

echo " -- Setting is starting -- "
echo 'export PATH=$PATH:$HOME/.dotnet' >> ~/.bashrc
source ~/.bashrc

mkdir -p ~/environment/.c9/runners
touch ~/environment/.c9/runners/.NETCore.run

cat << EOM >> ~/environment/.c9/runners/.NETCore.run
{
  "script": [
    "dotnet clean --verbosity minimal",
    "env StartupObject=\$file_base_name dotnet run"
  ],
  "info": "Building \$file_name and running \$file_base_name",
  "working_dir" : "\$file_path",
  "selector": "source.cs",
  "trackId": "CSharp"
}
EOM

rm -rf dotnet-install.sh

echo " -- Setting is completed -- "
