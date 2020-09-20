// Copyright Epic Games, Inc. All Rights Reserved.

#include "StarSphereGameMode.h"
#include "StarSpherePawn.h"

AStarSphereGameMode::AStarSphereGameMode()
{
	// set default pawn class to our flying pawn
	DefaultPawnClass = AStarSpherePawn::StaticClass();
}
