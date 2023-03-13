using UnityEngine;

public class Shop : MonoBehaviour {

	public TurretBlueprint standardTurret;
	public TurretBlueprint missileLauncher;
	public TurretBlueprint laserBeamer;

	BuildManager buildManager;

	void Start ()
	{
		buildManager = BuildManager.instance;
	}
//Seleccion de torre estandar
	public void SelectStandardTurret ()
	{
		Debug.Log("Standard Turret Selected");
		buildManager.SelectTurretToBuild(standardTurret);
	}
//Lanzacohetes
	public void SelectMissileLauncher()
	{
		Debug.Log("Missile Launcher Selected");
		buildManager.SelectTurretToBuild(missileLauncher);
	}
//Cañon laser
	public void SelectLaserBeamer()
	{
		Debug.Log("Laser Beamer Selected");
		buildManager.SelectTurretToBuild(laserBeamer);
	}

}
