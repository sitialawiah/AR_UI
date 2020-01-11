public float scallingspeed = 0.01f;
bool ScaleUp = false;
bool ScaleDown = false;

//update is called once per frame
void Update() {
    if (ScaleUp==true)
        ScaleUpButton();
    if (ScaleDown==true)
        ScaleDownButton();
}
public void ScaleUpButton()
{
    GameObject.FindWithTag("People").transform.localScale +=new Vector3(scallingspeed, scallingspeed, scallingspeed);
}
public void ScaleDownButton()
{
    GameObject.FindWithTag("People").transform.localScale +=new Vector3(-scallingspeed, -scallingspeed, -scallingspeed);
}

public void Up()
{
    ScaleUp = true;
    ScaleDown = false;
}
public void Down()
{
    ScaleUp = false;
    ScaleDown = true;
}
public void Stop()
{
    ScaleUp = false;
    ScaleDown = false;
}