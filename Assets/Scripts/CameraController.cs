using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private CustomEvent IntroDone;
    private CinemachineVirtualCamera virtualCamera;
    private GameObject cinemachineCameraTarget;

    void Start()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
        cinemachineCameraTarget = GameObject.FindGameObjectWithTag("PlayerCameraRoot");
    }

    public void CutSceneEnd()
    {
        if (virtualCamera != null)
            virtualCamera.Follow = cinemachineCameraTarget.transform;
        IntroDone.Occurred();
    }

}
