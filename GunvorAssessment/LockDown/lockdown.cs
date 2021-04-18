
using System;

namespace GunvorAssessment.LockDown
{
public class LockDown : ILockDown {
public void EndLockDown(){
}
public event EventHandler LockDownStarted(){}

public event EventHandler LockDownEnded(){}

public void StartLockDown(){}

}
}
