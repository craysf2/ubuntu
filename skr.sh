mkdir strukturacd strukturamkdir desktopmkdir documentsmkdir downloadsmkdir picturesmkdir videoscd ..for i in {1..5}domkdir folder$idonefor i in {1..5}dosudo useradd -m --groups sudo uporabnik$idonesudo apt updatesudo apt-get install net-toolssudo apt-get updatesudo apt-get install gitsudo apt-get updatesudo apt-get install \    ca-certificates \    curl \    gnupg \    lsb-releasesudo mkdir -p /etc/apt/keyringscurl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo gpg --dearmor -o /etc/apt/keyrings/docker.gpgecho \  "deb [arch=$(dpkg --print-architecture) signed-by=/etc/apt/keyrings/docker.gpg] https://download.docker.com/linux/ubuntu \  $(lsb_release -cs) stable" | sudo tee /etc/apt/sources.list.d/docker.list > /dev/nullsudo apt-get updatesudo apt-get install docker-ce docker-ce-cli containerd.io docker-compose-pluginsudo docker run hello-world