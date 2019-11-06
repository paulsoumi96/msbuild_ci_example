node {
def app
def commit_username
def commit_email
def gituserName
   
   stage('Checkout') {
	withFolderProperties{ 
	 git branch: env.gitBranch, url: "https://github.com/paulsoumi96/msbuild_ci_example.git"
	 props = readProperties  file: """jenkinsJob.properties"""
         workspace = pwd ()
	 commit_username=sh(returnStdout: true, script: '''username=$(git log -1 --pretty=%an) 
                                                            echo ${username%@*} ''').trim();
	 commit_username=sh(returnStdout: true, script: """echo ${commit_username} | sed 's/48236651+//g'""").trim()
	 commit_Email=sh(returnStdout: true, script: '''Email=$(git log -1 --pretty=%ae) 
                                                            echo $Email''').trim();
	 gituserName=sh(returnStdout: true, script: """echo \$(dirname ${env.gitUrl.trim()})""").trim();
	 gituserName=sh(returnStdout: true, script: """echo \$(basename ${gituserName.trim()})""").trim();
			sh"""echo ${gituserName}""" 
   	}
   }
   stage ('Build') {
      msbuild Build.proj -t:Build
   }
   stage ('Docker Image Build') {
       
   }
   stage('Run Container') {
      
   }
}
