
using System;

namespace GunvorAssessment.LockDown
{
public class LockDown : ILockDownManager {
public void EndLockDown(){
}
public event EventHandler LockDownStarted(){}

public event EventHandler LockDownEnded(){}

public void StartLockDown(){}

}
}
