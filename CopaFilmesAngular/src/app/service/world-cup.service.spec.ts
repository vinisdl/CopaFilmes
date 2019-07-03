import { TestBed, inject } from '@angular/core/testing';

import { WorldCupService } from './world-cup.service';

describe('WorldCupService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [WorldCupService]
    });
  });

  it('should be created', inject([WorldCupService], (service: WorldCupService) => {
    expect(service).toBeTruthy();
  }));
});
